namespace TASITJ_3005
{
    partial class FormStartSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX_Produce_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Type = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxX_Remarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.button_Start = new DevComponents.DotNetBar.ButtonX();
            this.Text_Kistler_ProNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "样品名称:";
            // 
            // textBoxX_Produce_name
            // 
            // 
            // 
            // 
            this.textBoxX_Produce_name.Border.Class = "TextBoxBorder";
            this.textBoxX_Produce_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_Produce_name.Location = new System.Drawing.Point(94, 22);
            this.textBoxX_Produce_name.Name = "textBoxX_Produce_name";
            this.textBoxX_Produce_name.PreventEnterBeep = true;
            this.textBoxX_Produce_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxX_Produce_name.Size = new System.Drawing.Size(125, 21);
            this.textBoxX_Produce_name.TabIndex = 2;
            this.textBoxX_Produce_name.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "压机程序号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "口模型号:";
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
            this.comboBox_Type.Location = new System.Drawing.Point(94, 62);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Type.Size = new System.Drawing.Size(125, 22);
            this.comboBox_Type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBox_Type.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "备注:";
            // 
            // textBoxX_Remarks
            // 
            // 
            // 
            // 
            this.textBoxX_Remarks.Border.Class = "TextBoxBorder";
            this.textBoxX_Remarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_Remarks.Location = new System.Drawing.Point(94, 104);
            this.textBoxX_Remarks.Name = "textBoxX_Remarks";
            this.textBoxX_Remarks.PreventEnterBeep = true;
            this.textBoxX_Remarks.Size = new System.Drawing.Size(253, 21);
            this.textBoxX_Remarks.TabIndex = 8;
            // 
            // button_Cancel
            // 
            this.button_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(237, 149);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "取  消";
            // 
            // button_Start
            // 
            this.button_Start.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Start.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Start.Location = new System.Drawing.Point(105, 149);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Start.TabIndex = 9;
            this.button_Start.Text = "开  始";
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Text_Kistler_ProNum
            // 
            // 
            // 
            // 
            this.Text_Kistler_ProNum.Border.Class = "TextBoxBorder";
            this.Text_Kistler_ProNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Text_Kistler_ProNum.Location = new System.Drawing.Point(322, 22);
            this.Text_Kistler_ProNum.Name = "Text_Kistler_ProNum";
            this.Text_Kistler_ProNum.PreventEnterBeep = true;
            this.Text_Kistler_ProNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text_Kistler_ProNum.Size = new System.Drawing.Size(25, 21);
            this.Text_Kistler_ProNum.TabIndex = 11;
            this.Text_Kistler_ProNum.Text = "0";
            this.Text_Kistler_ProNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_PressNum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "(0-127)";
            // 
            // FormStartSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(417, 188);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Text_Kistler_ProNum);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBoxX_Remarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX_Produce_name);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStartSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "程序设定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Produce_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Type;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Remarks;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.ButtonX button_Cancel;
        private DevComponents.DotNetBar.ButtonX button_Start;
        private DevComponents.DotNetBar.Controls.TextBoxX Text_Kistler_ProNum;
        private System.Windows.Forms.Label label5;
    }
}