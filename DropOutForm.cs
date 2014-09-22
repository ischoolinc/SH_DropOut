using Aspose.Words;
using FISCA.Data;
using FISCA.Presentation.Controls;
using K12.Data;
using K12.Data.Configuration;
using SHSchool.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DropOut
{
	public partial class DropOutForm : BaseForm
	{
		private List<string> studentIds;
		private int schoolYear, semester;
		private string No1, No2;
		private Document template;
		private string base64 = "";
		private bool _isDefaultTemplate = true;
		private byte[] _buffer = null;
		private byte[] defalutTemplate;
		private DateTime _startDate;
		private DateTime _endDate;
		private List<string> updateCode = new List<string> { "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "368" };

		public DropOutForm(List<string> selectClassIds)
		{
			InitializeComponent();
			// TODO: Complete member initialization
			studentIds = selectClassIds;

			_startDate = DateTime.Now;
			dateTimeInput1.Value = _startDate;

			defalutTemplate = Properties.Resources.休學證明書;
			
		}

		private string SelectTime() //取得Server的時間
		{
			QueryHelper Sql = new QueryHelper();
			DataTable dtable = Sql.Select("select now()"); //取得時間
			DateTime dt = DateTime.Now;
			DateTime.TryParse("" + dtable.Rows[0][0], out dt); //Parse資料
			string ComputerSendTime = dt.ToString("yyyy年MM月dd日"); //最後時間

			return ComputerSendTime;
		}


		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (textBoxX1.Text.Trim() == "" || textBoxX2.Text.Trim() == "")
				if (MessageBox.Show("校內文號輸入不完整，請問是否繼續列印 ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
					return;

			_endDate = dateTimeInput2.Value; 

			BackgroundWorker bgw = new BackgroundWorker();
			bgw = new BackgroundWorker();
			bgw.DoWork += new DoWorkEventHandler(_bgWorker_DoWork);
			bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_bgWorker_RunWorkerCompleted);
			bgw.RunWorkerAsync();
		}


		private void _bgWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			//取得文號、字號
			No1 = textBoxX1.Text;
			No2 = textBoxX2.Text;

			//選擇預設範本時的動作

			if (radioButton1.Checked == true)
			{
				defalutTemplate = Properties.Resources.休學證明書;
			}

			//選擇自訂範本時的動作
			if (radioButton2.Checked == true)
			{
				
			}

			//學年度學期取得
			schoolYear = int.Parse(K12.Data.School.DefaultSchoolYear);
			semester = int.Parse(K12.Data.School.DefaultSemester);


			//取得學校名稱
			string DSNSName = SHSchool.Data.SHSchoolInfo.ChineseName;
			string Principal = K12.Data.School.Configuration["學校資訊"].PreviousData.SelectSingleNode("ChancellorChineseName").InnerText;

			//取得選取學生
			List<SHStudentRecord> studentAll = SHStudent.SelectByIDs(studentIds);

			Document doc = new Document();
			Dictionary<string, object> merge = new Dictionary<string, object>();
			List<SHUpdateRecordRecord> updateRecord = SHUpdateRecord.SelectByStudentIDs(studentIds);

			Document perPage = (new Document(new MemoryStream(defalutTemplate))).Clone();
			Dictionary<string, StudentObj> dic = new Dictionary<string, StudentObj>();

			foreach (SHUpdateRecordRecord urr in updateRecord)
			{
				if (dic.ContainsKey(urr.StudentID))
				{
					SHUpdateRecordRecord old = dic[urr.StudentID].URR;
					int newSchoolYear = urr.SchoolYear.HasValue ? urr.SchoolYear.Value : 0;
					int newSemester = urr.Semester.HasValue ? urr.Semester.Value : 0;
					int oldSchoolYear = old.SchoolYear.HasValue ? old.SchoolYear.Value : 0;
					int oldSemester = old.Semester.HasValue ? old.Semester.Value : 0;

					if (newSchoolYear > oldSchoolYear)
						dic[urr.StudentID].URR = urr;
					else if (newSchoolYear == oldSchoolYear)
					{
						if (newSemester > oldSemester)
							dic[urr.StudentID].URR = urr;
					}
				}

				if (updateCode.Contains(urr.UpdateCode) && !dic.ContainsKey(urr.StudentID))
				{
					dic.Add(urr.StudentID, new StudentObj());
					
					dic[urr.StudentID].URR = urr;
				}
			}


			foreach (SHStudentRecord sr in studentAll)
			{
				if (dic.ContainsKey(sr.ID))
					dic[sr.ID].Student = sr;
			}

			foreach (StudentObj obj in dic.Values)
			{
				if (!dic.Values.Contains(obj))
				{
					merge.Add("起始時間", _startDate.ToString("yyyy年MM月dd日"));
					merge.Add("訖末時間", _endDate.ToString("yyyy年MM月dd日"));

					merge.Add("編字", No1);
					merge.Add("編號", No2);
					merge.Add("年級", schoolYear);
					merge.Add("學期", semester);
					merge.Add("學校名稱", DSNSName);
					merge.Add("校長姓名", Principal);
					merge.Add("列印日期", SelectTime());
					merge.Add("學生姓名", obj.Student.Name);
					merge.Add("學號", obj.Student.StudentNumber);
					merge.Add("休學年級", obj.URR.PreviousDepartment);
					merge.Add("休學學期", obj.URR.Semester);
					merge.Add("復學年級", obj.URR.PreviousDepartment);
					merge.Add("科系", obj.URR == null ? string.Empty : obj.URR.Department);

					merge.Add("休學事由", obj.URR == null ? string.Empty : obj.URR.UpdateDescription);
				}
				
				perPage.MailMerge.Execute(merge.Keys.ToArray<string>(), merge.Values.ToArray<object>());
				perPage.MailMerge.RemoveEmptyParagraphs = true;
				perPage.MailMerge.DeleteFields();

				doc.Sections.Add(doc.ImportNode(perPage.Sections[0], true));
			}
			doc.Sections.RemoveAt(0);
			e.Result = doc;
		}

		void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				FISCA.Presentation.Controls.MsgBox.Show("產生過程發生錯誤:" + e.Error.Message);
				return;
			}

			Document document = (Document)e.Result;
			string inputReportName = "休學證明書";
			string reportName = inputReportName;

			System.Windows.Forms.SaveFileDialog sd = new System.Windows.Forms.SaveFileDialog();
			sd.Title = "另存新檔";
			sd.FileName = reportName + ".doc";
			sd.Filter = "Word檔案 (*.doc)|*.doc|所有檔案 (*.*)|*.*";
			if (sd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					document.Save(sd.FileName, Aspose.Words.SaveFormat.Doc);
					System.Diagnostics.Process.Start(sd.FileName);
				}
				catch (Exception ex)
				{
					FISCA.Presentation.Controls.MsgBox.Show("指定路徑無法存取。", "建立檔案失敗", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// 設定使用者自訂範本
		/// </summary>
		public void SetUserDefineTemplateToSystem()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "選擇自訂的轉學證明書範本";
			ofd.Filter = "Word檔案 (*.doc)|*.doc";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if (Document.DetectFileFormat(ofd.FileName) == LoadFormat.Doc)
					{
						FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

						byte[] tempBuffer = new byte[fs.Length];
						fs.Read(tempBuffer, 0, tempBuffer.Length);
						base64 = Convert.ToBase64String(tempBuffer);
						fs.Close();
						SaveTemplateToSystem();
						//PermRecLogProcess prlp = new PermRecLogProcess();
						//prlp.SaveLog("學生.報表", "上傳", "上傳轉學證明書樣版.");

						MsgBox.Show("上傳成功。");
					}
					else
						MsgBox.Show("上傳檔案格式不符");
				}
				catch
				{
					MsgBox.Show("指定路徑無法存取。", "開啟檔案失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

		}

		/// <summary>
		/// 儲存使用者定義
		/// </summary>
		public void SaveTemplateToSystem()
		{
			ConfigData cd = School.Configuration["轉學證明書_無成績"];
			cd["Default"] = _isDefaultTemplate.ToString();
			cd["CustomizeTemplate"] = base64;
			cd.Save();
		}

		/// <summary>
		/// 儲存預設樣版
		/// </summary>
		public void SaveDefaulTemplate()
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "另存新檔";
			sfd.FileName = "休學證明書(樣板).doc";
			sfd.Filter = "Word檔案 (*.doc)|*.doc|所有檔案 (*.*)|*.*";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{

					FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
					fs.Write(defalutTemplate, 0, defalutTemplate.Length);
					fs.Close();
					System.Diagnostics.Process.Start(sfd.FileName);
				}
				catch
				{
					MsgBox.Show("指定路徑無法存取。", "另存檔案失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		/// <summary>
		/// 儲存使用者自訂樣版
		/// </summary>
		public void SaveUserDefineTemplate()
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "另存新檔";
			sfd.FileName = "自訂休學證明書.doc";
			sfd.Filter = "Word檔案 (*.doc)|*.doc|所有檔案 (*.*)|*.*";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
					if (_buffer != null && Aspose.Words.Document.DetectFileFormat(new MemoryStream(_buffer)) == Aspose.Words.LoadFormat.Doc)
						fs.Write(_buffer, 0, _buffer.Length);
					else
						fs.Write(defalutTemplate, 0, defalutTemplate.Length);
					fs.Close();
					System.Diagnostics.Process.Start(sfd.FileName);
				}
				catch
				{
					MsgBox.Show("指定路徑無法存取。", "另存檔案失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}


		}


		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SetUserDefineTemplateToSystem();
		}

		private void linkDefault_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SaveDefaulTemplate();
		}

		private void linkCustom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SaveUserDefineTemplate();
		}

	}
}
