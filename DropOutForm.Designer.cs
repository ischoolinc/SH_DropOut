namespace DropOut
{
	partial class DropOutForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnPrint = new DevComponents.DotNetBar.ButtonX();
			this.btnClose = new DevComponents.DotNetBar.ButtonX();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.labelX1 = new DevComponents.DotNetBar.LabelX();
			this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.labelX2 = new DevComponents.DotNetBar.LabelX();
			this.labelX3 = new DevComponents.DotNetBar.LabelX();
			this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.dateTimeInput2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.linkDefault = new System.Windows.Forms.LinkLabel();
			this.linkCustom = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPrint
			// 
			this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnPrint.BackColor = System.Drawing.Color.Transparent;
			this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnPrint.Location = new System.Drawing.Point(167, 163);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnPrint.TabIndex = 0;
			this.btnPrint.Text = "列印";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnClose
			// 
			this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnClose.Location = new System.Drawing.Point(246, 163);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "取消";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.BackColor = System.Drawing.Color.Transparent;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(18, 140);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(14, 13);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.UseVisualStyleBackColor = false;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.BackColor = System.Drawing.Color.Transparent;
			this.radioButton2.Location = new System.Drawing.Point(18, 167);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(14, 13);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.TabStop = true;
			this.radioButton2.UseVisualStyleBackColor = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(104, 165);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(34, 17);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "上傳";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(21, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "校內文號";
			// 
			// textBoxX1
			// 
			// 
			// 
			// 
			this.textBoxX1.Border.Class = "TextBoxBorder";
			this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.textBoxX1.Location = new System.Drawing.Point(93, 102);
			this.textBoxX1.Name = "textBoxX1";
			this.textBoxX1.Size = new System.Drawing.Size(85, 25);
			this.textBoxX1.TabIndex = 9;
			// 
			// labelX1
			// 
			this.labelX1.BackColor = System.Drawing.Color.Transparent;
			// 
			// 
			// 
			this.labelX1.BackgroundStyle.Class = "";
			this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labelX1.Location = new System.Drawing.Point(184, 102);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new System.Drawing.Size(40, 23);
			this.labelX1.TabIndex = 10;
			this.labelX1.Text = "字  第";
			// 
			// textBoxX2
			// 
			// 
			// 
			// 
			this.textBoxX2.Border.Class = "TextBoxBorder";
			this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.textBoxX2.Location = new System.Drawing.Point(230, 102);
			this.textBoxX2.Name = "textBoxX2";
			this.textBoxX2.Size = new System.Drawing.Size(44, 25);
			this.textBoxX2.TabIndex = 11;
			// 
			// labelX2
			// 
			this.labelX2.BackColor = System.Drawing.Color.Transparent;
			// 
			// 
			// 
			this.labelX2.BackgroundStyle.Class = "";
			this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labelX2.Location = new System.Drawing.Point(284, 104);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new System.Drawing.Size(20, 23);
			this.labelX2.TabIndex = 12;
			this.labelX2.Text = "號";
			// 
			// labelX3
			// 
			this.labelX3.BackColor = System.Drawing.Color.Transparent;
			// 
			// 
			// 
			this.labelX3.BackgroundStyle.Class = "";
			this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labelX3.Location = new System.Drawing.Point(24, 16);
			this.labelX3.Name = "labelX3";
			this.labelX3.Size = new System.Drawing.Size(60, 23);
			this.labelX3.TabIndex = 13;
			this.labelX3.Text = "休學起訖";
			// 
			// dateTimeInput1
			// 
			this.dateTimeInput1.BackColor = System.Drawing.Color.Transparent;
			// 
			// 
			// 
			this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
			this.dateTimeInput1.ButtonDropDown.Visible = true;
			this.dateTimeInput1.IsPopupCalendarOpen = false;
			this.dateTimeInput1.Location = new System.Drawing.Point(93, 16);
			// 
			// 
			// 
			this.dateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
			// 
			// 
			// 
			this.dateTimeInput1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
			this.dateTimeInput1.MonthCalendar.BackgroundStyle.Class = "";
			this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
			// 
			// 
			// 
			this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.Class = "";
			this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
			this.dateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
			this.dateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
			// 
			// 
			// 
			this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.Class = "";
			this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
			this.dateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
			this.dateTimeInput1.Name = "dateTimeInput1";
			this.dateTimeInput1.Size = new System.Drawing.Size(200, 25);
			this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dateTimeInput1.TabIndex = 14;
			// 
			// dateTimeInput2
			// 
			this.dateTimeInput2.BackColor = System.Drawing.Color.Transparent;
			// 
			// 
			// 
			this.dateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
			this.dateTimeInput2.ButtonDropDown.Visible = true;
			this.dateTimeInput2.IsPopupCalendarOpen = false;
			this.dateTimeInput2.Location = new System.Drawing.Point(93, 61);
			// 
			// 
			// 
			this.dateTimeInput2.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
			// 
			// 
			// 
			this.dateTimeInput2.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
			this.dateTimeInput2.MonthCalendar.BackgroundStyle.Class = "";
			this.dateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dateTimeInput2.MonthCalendar.ClearButtonVisible = true;
			// 
			// 
			// 
			this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.Class = "";
			this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dateTimeInput2.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
			this.dateTimeInput2.MonthCalendar.MarkedDates = new System.DateTime[0];
			this.dateTimeInput2.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
			// 
			// 
			// 
			this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.Class = "";
			this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dateTimeInput2.MonthCalendar.TodayButtonVisible = true;
			this.dateTimeInput2.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
			this.dateTimeInput2.Name = "dateTimeInput2";
			this.dateTimeInput2.Size = new System.Drawing.Size(200, 25);
			this.dateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dateTimeInput2.TabIndex = 15;
			// 
			// linkDefault
			// 
			this.linkDefault.AutoSize = true;
			this.linkDefault.BackColor = System.Drawing.Color.Transparent;
			this.linkDefault.Location = new System.Drawing.Point(38, 140);
			this.linkDefault.Name = "linkDefault";
			this.linkDefault.Size = new System.Drawing.Size(60, 17);
			this.linkDefault.TabIndex = 16;
			this.linkDefault.TabStop = true;
			this.linkDefault.Text = "預設樣板";
			this.linkDefault.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDefault_LinkClicked);
			// 
			// linkCustom
			// 
			this.linkCustom.AutoSize = true;
			this.linkCustom.BackColor = System.Drawing.Color.Transparent;
			this.linkCustom.Location = new System.Drawing.Point(38, 165);
			this.linkCustom.Name = "linkCustom";
			this.linkCustom.Size = new System.Drawing.Size(60, 17);
			this.linkCustom.TabIndex = 17;
			this.linkCustom.TabStop = true;
			this.linkCustom.Text = "自訂樣板";
			this.linkCustom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCustom_LinkClicked);
			// 
			// DropOutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 202);
			this.Controls.Add(this.linkCustom);
			this.Controls.Add(this.linkDefault);
			this.Controls.Add(this.dateTimeInput2);
			this.Controls.Add(this.dateTimeInput1);
			this.Controls.Add(this.labelX3);
			this.Controls.Add(this.labelX2);
			this.Controls.Add(this.textBoxX2);
			this.Controls.Add(this.labelX1);
			this.Controls.Add(this.textBoxX1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnPrint);
			this.DoubleBuffered = true;
			this.Name = "DropOutForm";
			this.Text = "列印休學證明書";
			((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevComponents.DotNetBar.ButtonX btnPrint;
		private DevComponents.DotNetBar.ButtonX btnClose;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label1;
		private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
		private DevComponents.DotNetBar.LabelX labelX1;
		private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
		private DevComponents.DotNetBar.LabelX labelX2;
		private DevComponents.DotNetBar.LabelX labelX3;
		private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
		private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput2;
		private System.Windows.Forms.LinkLabel linkDefault;
		private System.Windows.Forms.LinkLabel linkCustom;
	}
}