namespace TASITJ_3005
{
    partial class FormSet
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
            this.label2 = new System.Windows.Forms.Label();
            this.text_Path_1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.text_Path_2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button_Sel_Path_1 = new DevComponents.DotNetBar.ButtonX();
            this.button_Sel_Path_2 = new DevComponents.DotNetBar.ButtonX();
            this.button_Save = new DevComponents.DotNetBar.ButtonX();
            this.button_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.button_Sel_Path_4 = new DevComponents.DotNetBar.ButtonX();
            this.button_Sel_Path_3 = new DevComponents.DotNetBar.ButtonX();
            this.text_Path_4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.text_Path_3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kistler1文件夹路径:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kistler2文件夹路径:";
            // 
            // text_Path_1
            // 
            // 
            // 
            // 
            this.text_Path_1.Border.Class = "TextBoxBorder";
            this.text_Path_1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.text_Path_1.Enabled = false;
            this.text_Path_1.Location = new System.Drawing.Point(137, 22);
            this.text_Path_1.Name = "text_Path_1";
            this.text_Path_1.PreventEnterBeep = true;
            this.text_Path_1.Size = new System.Drawing.Size(256, 21);
            this.text_Path_1.TabIndex = 2;
            // 
            // text_Path_2
            // 
            // 
            // 
            // 
            this.text_Path_2.Border.Class = "TextBoxBorder";
            this.text_Path_2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.text_Path_2.Enabled = false;
            this.text_Path_2.Location = new System.Drawing.Point(137, 60);
            this.text_Path_2.Name = "text_Path_2";
            this.text_Path_2.PreventEnterBeep = true;
            this.text_Path_2.Size = new System.Drawing.Size(256, 21);
            this.text_Path_2.TabIndex = 3;
            // 
            // button_Sel_Path_1
            // 
            this.button_Sel_Path_1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Sel_Path_1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Sel_Path_1.Location = new System.Drawing.Point(399, 21);
            this.button_Sel_Path_1.Name = "button_Sel_Path_1";
            this.button_Sel_Path_1.Size = new System.Drawing.Size(75, 23);
            this.button_Sel_Path_1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Sel_Path_1.TabIndex = 4;
            this.button_Sel_Path_1.Text = "选择路径";
            this.button_Sel_Path_1.Click += new System.EventHandler(this.button_Sel_Path_1_Click);
            // 
            // button_Sel_Path_2
            // 
            this.button_Sel_Path_2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Sel_Path_2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Sel_Path_2.Location = new System.Drawing.Point(399, 59);
            this.button_Sel_Path_2.Name = "button_Sel_Path_2";
            this.button_Sel_Path_2.Size = new System.Drawing.Size(75, 23);
            this.button_Sel_Path_2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Sel_Path_2.TabIndex = 5;
            this.button_Sel_Path_2.Text = "选择路径";
            this.button_Sel_Path_2.Click += new System.EventHandler(this.button_Sel_Path_2_Click);
            // 
            // button_Save
            // 
            this.button_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Save.Location = new System.Drawing.Point(137, 179);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "保  存";
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(269, 179);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "取  消";
            // 
            // button_Sel_Path_4
            // 
            this.button_Sel_Path_4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Sel_Path_4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Sel_Path_4.Location = new System.Drawing.Point(399, 136);
            this.button_Sel_Path_4.Name = "button_Sel_Path_4";
            this.button_Sel_Path_4.Size = new System.Drawing.Size(75, 23);
            this.button_Sel_Path_4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Sel_Path_4.TabIndex = 13;
            this.button_Sel_Path_4.Text = "选择路径";
            this.button_Sel_Path_4.Click += new System.EventHandler(this.button_Sel_Path_4_Click);
            // 
            // button_Sel_Path_3
            // 
            this.button_Sel_Path_3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Sel_Path_3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Sel_Path_3.Location = new System.Drawing.Point(399, 98);
            this.button_Sel_Path_3.Name = "button_Sel_Path_3";
            this.button_Sel_Path_3.Size = new System.Drawing.Size(75, 23);
            this.button_Sel_Path_3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_Sel_Path_3.TabIndex = 12;
            this.button_Sel_Path_3.Text = "选择路径";
            this.button_Sel_Path_3.Click += new System.EventHandler(this.button_Sel_Path_3_Click);
            // 
            // text_Path_4
            // 
            // 
            // 
            // 
            this.text_Path_4.Border.Class = "TextBoxBorder";
            this.text_Path_4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.text_Path_4.Enabled = false;
            this.text_Path_4.Location = new System.Drawing.Point(137, 137);
            this.text_Path_4.Name = "text_Path_4";
            this.text_Path_4.PreventEnterBeep = true;
            this.text_Path_4.Size = new System.Drawing.Size(256, 21);
            this.text_Path_4.TabIndex = 11;
            // 
            // text_Path_3
            // 
            // 
            // 
            // 
            this.text_Path_3.Border.Class = "TextBoxBorder";
            this.text_Path_3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.text_Path_3.Enabled = false;
            this.text_Path_3.Location = new System.Drawing.Point(137, 99);
            this.text_Path_3.Name = "text_Path_3";
            this.text_Path_3.PreventEnterBeep = true;
            this.text_Path_3.Size = new System.Drawing.Size(256, 21);
            this.text_Path_3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kistler2历史文件夹:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kistler1历史文件夹:";
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(490, 213);
            this.Controls.Add(this.button_Sel_Path_4);
            this.Controls.Add(this.button_Sel_Path_3);
            this.Controls.Add(this.text_Path_4);
            this.Controls.Add(this.text_Path_3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Sel_Path_2);
            this.Controls.Add(this.button_Sel_Path_1);
            this.Controls.Add(this.text_Path_2);
            this.Controls.Add(this.text_Path_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "软件设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX text_Path_1;
        private DevComponents.DotNetBar.Controls.TextBoxX text_Path_2;
        private DevComponents.DotNetBar.ButtonX button_Sel_Path_1;
        private DevComponents.DotNetBar.ButtonX button_Sel_Path_2;
        private DevComponents.DotNetBar.ButtonX button_Save;
        private DevComponents.DotNetBar.ButtonX button_Cancel;
        private DevComponents.DotNetBar.ButtonX button_Sel_Path_4;
        private DevComponents.DotNetBar.ButtonX button_Sel_Path_3;
        private DevComponents.DotNetBar.Controls.TextBoxX text_Path_4;
        private DevComponents.DotNetBar.Controls.TextBoxX text_Path_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}