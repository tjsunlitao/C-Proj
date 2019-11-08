namespace TASITJ_3005
{
    partial class FormHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_SingleDataExport = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_FullDataExport = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_SingleDataDelete = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_FullDataDelete = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.button_Seach = new DevComponents.DotNetBar.ButtonX();
            this.dateTimeInput2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Type = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Kistler_ProNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX_Produce_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_PressNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contextMenuBar1);
            this.groupBox1.Controls.Add(this.button_Seach);
            this.groupBox1.Controls.Add(this.dateTimeInput2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimeInput1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_Type);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Text_Kistler_ProNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxX_Produce_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.contextMenuBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar1.Location = new System.Drawing.Point(934, 53);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(100, 26);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 21;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_SingleDataExport,
            this.buttonItem_FullDataExport,
            this.buttonItem_SingleDataDelete,
            this.buttonItem_FullDataDelete});
            this.buttonItem1.Text = "button1";
            // 
            // buttonItem_SingleDataExport
            // 
            this.buttonItem_SingleDataExport.Name = "buttonItem_SingleDataExport";
            this.buttonItem_SingleDataExport.Text = "导出选择数据";
            this.buttonItem_SingleDataExport.Click += new System.EventHandler(this.buttonItem_SingleDataExport_Click);
            // 
            // buttonItem_FullDataExport
            // 
            this.buttonItem_FullDataExport.Name = "buttonItem_FullDataExport";
            this.buttonItem_FullDataExport.Text = "导出全部数据";
            this.buttonItem_FullDataExport.Click += new System.EventHandler(this.buttonItem_FullDataExport_Click);
            // 
            // buttonItem_SingleDataDelete
            // 
            this.buttonItem_SingleDataDelete.Name = "buttonItem_SingleDataDelete";
            this.buttonItem_SingleDataDelete.Text = "导出并删除选择数据";
            this.buttonItem_SingleDataDelete.Click += new System.EventHandler(this.buttonItem_SingleDataDelete_Click);
            // 
            // buttonItem_FullDataDelete
            // 
            this.buttonItem_FullDataDelete.Name = "buttonItem_FullDataDelete";
            this.buttonItem_FullDataDelete.Text = "导出并删除全部数据";
            this.buttonItem_FullDataDelete.Click += new System.EventHandler(this.buttonItem_FullDataDelete_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreateTime,
            this.Product_Name,
            this.Product_PressNum,
            this.Product_Type,
            this.Product_Remarks});
            this.contextMenuBar1.SetContextMenuEx(this.dataGridViewX1, this.buttonItem1);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.SelectAllSignVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(1071, 541);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellDoubleClick);
            // 
            // button_Seach
            // 
            this.button_Seach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Seach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Seach.Location = new System.Drawing.Point(910, 31);
            this.button_Seach.Name = "button_Seach";
            this.button_Seach.Size = new System.Drawing.Size(75, 23);
            this.button_Seach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Seach.TabIndex = 20;
            this.button_Seach.Text = "开始搜索";
            this.button_Seach.Click += new System.EventHandler(this.button_Seach_Click);
            // 
            // dateTimeInput2
            // 
            // 
            // 
            // 
            this.dateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput2.ButtonDropDown.Visible = true;
            this.dateTimeInput2.CustomFormat = "yyyy/MM/dd";
            this.dateTimeInput2.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInput2.IsPopupCalendarOpen = false;
            this.dateTimeInput2.Location = new System.Drawing.Point(760, 31);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
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
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.DisplayMonth = new System.DateTime(2019, 7, 1, 0, 0, 0, 0);
            this.dateTimeInput2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput2.Name = "dateTimeInput2";
            this.dateTimeInput2.Size = new System.Drawing.Size(121, 21);
            this.dateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "结束时间:";
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.CustomFormat = "yyyy/MM/dd";
            this.dateTimeInput1.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInput1.IsPopupCalendarOpen = false;
            this.dateTimeInput1.Location = new System.Drawing.Point(558, 31);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
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
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2019, 7, 1, 0, 0, 0, 0);
            this.dateTimeInput1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(121, 21);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "开始时间:";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DisplayMember = "Text";
            this.comboBox_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.ItemHeight = 16;
            this.comboBox_Type.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.comboBox_Type.Location = new System.Drawing.Point(386, 31);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Type.Size = new System.Drawing.Size(91, 22);
            this.comboBox_Type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBox_Type.TabIndex = 15;
            // 
            // comboItem1
            // 
            this.comboItem1.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboItem1.Text = "100:1";
            // 
            // comboItem2
            // 
            this.comboItem2.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboItem2.Text = "400:1";
            // 
            // comboItem3
            // 
            this.comboItem3.ImagePosition = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboItem3.Text = "1600:1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "口模型号:";
            // 
            // Text_Kistler_ProNum
            // 
            // 
            // 
            // 
            this.Text_Kistler_ProNum.Border.Class = "TextBoxBorder";
            this.Text_Kistler_ProNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Text_Kistler_ProNum.Location = new System.Drawing.Point(281, 31);
            this.Text_Kistler_ProNum.Name = "Text_Kistler_ProNum";
            this.Text_Kistler_ProNum.PreventEnterBeep = true;
            this.Text_Kistler_ProNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text_Kistler_ProNum.Size = new System.Drawing.Size(25, 21);
            this.Text_Kistler_ProNum.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "压机程序号:";
            // 
            // textBoxX_Produce_name
            // 
            // 
            // 
            // 
            this.textBoxX_Produce_name.Border.Class = "TextBoxBorder";
            this.textBoxX_Produce_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_Produce_name.Location = new System.Drawing.Point(76, 31);
            this.textBoxX_Produce_name.Name = "textBoxX_Produce_name";
            this.textBoxX_Produce_name.PreventEnterBeep = true;
            this.textBoxX_Produce_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX_Produce_name.Size = new System.Drawing.Size(112, 21);
            this.textBoxX_Produce_name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "样品名称:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1077, 561);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss";
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CreateTime.Width = 150;
            // 
            // Product_Name
            // 
            this.Product_Name.DataPropertyName = "Product_Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product_Name.DefaultCellStyle = dataGridViewCellStyle3;
            this.Product_Name.HeaderText = "样品名称";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Product_Name.Width = 180;
            // 
            // Product_PressNum
            // 
            this.Product_PressNum.DataPropertyName = "Product_PressNum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product_PressNum.DefaultCellStyle = dataGridViewCellStyle4;
            this.Product_PressNum.HeaderText = "压机程序号";
            this.Product_PressNum.Name = "Product_PressNum";
            this.Product_PressNum.ReadOnly = true;
            this.Product_PressNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Type
            // 
            this.Product_Type.DataPropertyName = "Product_Type";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product_Type.DefaultCellStyle = dataGridViewCellStyle5;
            this.Product_Type.HeaderText = "口模型号";
            this.Product_Type.Name = "Product_Type";
            this.Product_Type.ReadOnly = true;
            this.Product_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Product_Type.Width = 130;
            // 
            // Product_Remarks
            // 
            this.Product_Remarks.DataPropertyName = "Product_Remarks";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product_Remarks.DefaultCellStyle = dataGridViewCellStyle6;
            this.Product_Remarks.HeaderText = "备  注";
            this.Product_Remarks.Name = "Product_Remarks";
            this.Product_Remarks.ReadOnly = true;
            this.Product_Remarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Product_Remarks.Width = 468;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "历史数据";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Produce_name;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX Text_Kistler_ProNum;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Type;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput2;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ButtonX button_Seach;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem_SingleDataExport;
        private DevComponents.DotNetBar.ButtonItem buttonItem_FullDataExport;
        private DevComponents.DotNetBar.ButtonItem buttonItem_SingleDataDelete;
        private DevComponents.DotNetBar.ButtonItem buttonItem_FullDataDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_PressNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Remarks;
    }
}