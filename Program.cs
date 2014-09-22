using FISCA.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DropOut
{
    public class Program
    {
		[FISCA.MainMethod]
		public static void Main()
		{
			FISCA.Presentation.RibbonBarItem item1 = FISCA.Presentation.MotherForm.RibbonBarItems["學生", "資料統計"];
			item1["報表"].Image = Properties.Resources.Report;
			item1["報表"].Size = FISCA.Presentation.RibbonBarButton.MenuButtonSize.Large;
			item1["報表"]["學籍相關報表"]["休學證明書"].Enable = false;
			item1["報表"]["學籍相關報表"]["休學證明書"].Click += delegate
			{
				DropOutForm form = new DropOutForm(K12.Presentation.NLDPanels.Student.SelectedSource);
				form.ShowDialog();
			};

			K12.Presentation.NLDPanels.Student.SelectedSourceChanged += delegate
			{
				if (K12.Presentation.NLDPanels.Student.SelectedSource.Count > 0 && Permissions.休學證明書權限)
				{
					item1["報表"]["學籍相關報表"]["休學證明書"].Enable = true;
				}
				else
					item1["報表"]["學籍相關報表"]["休學證明書"].Enable = false;
			};
			//權限設定
			Catalog permission = RoleAclSource.Instance["學生"]["功能按鈕"];
			permission.Add(new RibbonFeature(Permissions.休學證明書, "休學證明書"));
		}
	}
}
