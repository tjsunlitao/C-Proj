namespace TASITJ_3005
{
    partial class FormCalc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTime_Min = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTime_Max = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.button_calc = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Dis_Min = new System.Windows.Forms.Label();
            this.label_Dis_Max = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_Str_Ave = new System.Windows.Forms.Label();
            this.label_Str_Max = new System.Windows.Forms.Label();
            this.label_Str_Min = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Pre_Ave = new System.Windows.Forms.Label();
            this.label_Pre_Max = new System.Windows.Forms.Label();
            this.label_Pre_Min = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_Spe_Ave = new System.Windows.Forms.Label();
            this.label_Spe_Max = new System.Windows.Forms.Label();
            this.label_Spe_Min = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "开始时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "结束时间:";
            // 
            // textBoxTime_Min
            // 
            // 
            // 
            // 
            this.textBoxTime_Min.Border.Class = "TextBoxBorder";
            this.textBoxTime_Min.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTime_Min.Location = new System.Drawing.Point(77, 20);
            this.textBoxTime_Min.Name = "textBoxTime_Min";
            this.textBoxTime_Min.PreventEnterBeep = true;
            this.textBoxTime_Min.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTime_Min.Size = new System.Drawing.Size(48, 21);
            this.textBoxTime_Min.TabIndex = 5;
            this.textBoxTime_Min.Text = "0";
            this.textBoxTime_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTime_Min_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "秒";
            // 
            // textBoxTime_Max
            // 
            // 
            // 
            // 
            this.textBoxTime_Max.Border.Class = "TextBoxBorder";
            this.textBoxTime_Max.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTime_Max.Location = new System.Drawing.Point(229, 20);
            this.textBoxTime_Max.Name = "textBoxTime_Max";
            this.textBoxTime_Max.PreventEnterBeep = true;
            this.textBoxTime_Max.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTime_Max.Size = new System.Drawing.Size(48, 21);
            this.textBoxTime_Max.TabIndex = 8;
            this.textBoxTime_Max.Text = "0";
            this.textBoxTime_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTime_Max_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "秒";
            // 
            // button_calc
            // 
            this.button_calc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_calc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_calc.Location = new System.Drawing.Point(328, 21);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(75, 23);
            this.button_calc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_calc.TabIndex = 21;
            this.button_calc.Text = "开始计算";
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "位  移";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "最小值:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "最大值:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "平均值:";
            // 
            // label_Dis_Min
            // 
            this.label_Dis_Min.AutoSize = true;
            this.label_Dis_Min.Location = new System.Drawing.Point(73, 91);
            this.label_Dis_Min.Name = "label_Dis_Min";
            this.label_Dis_Min.Size = new System.Drawing.Size(11, 12);
            this.label_Dis_Min.TabIndex = 26;
            this.label_Dis_Min.Text = "0";
            // 
            // label_Dis_Max
            // 
            this.label_Dis_Max.AutoSize = true;
            this.label_Dis_Max.Location = new System.Drawing.Point(73, 129);
            this.label_Dis_Max.Name = "label_Dis_Max";
            this.label_Dis_Max.Size = new System.Drawing.Size(11, 12);
            this.label_Dis_Max.TabIndex = 27;
            this.label_Dis_Max.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "压  力";
            // 
            // label_Str_Ave
            // 
            this.label_Str_Ave.AutoSize = true;
            this.label_Str_Ave.Location = new System.Drawing.Point(150, 167);
            this.label_Str_Ave.Name = "label_Str_Ave";
            this.label_Str_Ave.Size = new System.Drawing.Size(11, 12);
            this.label_Str_Ave.TabIndex = 32;
            this.label_Str_Ave.Text = "0";
            // 
            // label_Str_Max
            // 
            this.label_Str_Max.AutoSize = true;
            this.label_Str_Max.Location = new System.Drawing.Point(150, 129);
            this.label_Str_Max.Name = "label_Str_Max";
            this.label_Str_Max.Size = new System.Drawing.Size(11, 12);
            this.label_Str_Max.TabIndex = 31;
            this.label_Str_Max.Text = "0";
            // 
            // label_Str_Min
            // 
            this.label_Str_Min.AutoSize = true;
            this.label_Str_Min.Location = new System.Drawing.Point(150, 91);
            this.label_Str_Min.Name = "label_Str_Min";
            this.label_Str_Min.Size = new System.Drawing.Size(11, 12);
            this.label_Str_Min.TabIndex = 30;
            this.label_Str_Min.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "压  强";
            // 
            // label_Pre_Ave
            // 
            this.label_Pre_Ave.AutoSize = true;
            this.label_Pre_Ave.Location = new System.Drawing.Point(236, 167);
            this.label_Pre_Ave.Name = "label_Pre_Ave";
            this.label_Pre_Ave.Size = new System.Drawing.Size(11, 12);
            this.label_Pre_Ave.TabIndex = 36;
            this.label_Pre_Ave.Text = "0";
            // 
            // label_Pre_Max
            // 
            this.label_Pre_Max.AutoSize = true;
            this.label_Pre_Max.Location = new System.Drawing.Point(236, 129);
            this.label_Pre_Max.Name = "label_Pre_Max";
            this.label_Pre_Max.Size = new System.Drawing.Size(11, 12);
            this.label_Pre_Max.TabIndex = 35;
            this.label_Pre_Max.Text = "0";
            // 
            // label_Pre_Min
            // 
            this.label_Pre_Min.AutoSize = true;
            this.label_Pre_Min.Location = new System.Drawing.Point(236, 91);
            this.label_Pre_Min.Name = "label_Pre_Min";
            this.label_Pre_Min.Size = new System.Drawing.Size(11, 12);
            this.label_Pre_Min.TabIndex = 34;
            this.label_Pre_Min.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 37;
            this.label14.Text = "速  度";
            // 
            // label_Spe_Ave
            // 
            this.label_Spe_Ave.AutoSize = true;
            this.label_Spe_Ave.Location = new System.Drawing.Point(321, 167);
            this.label_Spe_Ave.Name = "label_Spe_Ave";
            this.label_Spe_Ave.Size = new System.Drawing.Size(11, 12);
            this.label_Spe_Ave.TabIndex = 40;
            this.label_Spe_Ave.Text = "0";
            // 
            // label_Spe_Max
            // 
            this.label_Spe_Max.AutoSize = true;
            this.label_Spe_Max.Location = new System.Drawing.Point(321, 129);
            this.label_Spe_Max.Name = "label_Spe_Max";
            this.label_Spe_Max.Size = new System.Drawing.Size(11, 12);
            this.label_Spe_Max.TabIndex = 39;
            this.label_Spe_Max.Text = "0";
            // 
            // label_Spe_Min
            // 
            this.label_Spe_Min.AutoSize = true;
            this.label_Spe_Min.Location = new System.Drawing.Point(321, 91);
            this.label_Spe_Min.Name = "label_Spe_Min";
            this.label_Spe_Min.Size = new System.Drawing.Size(11, 12);
            this.label_Spe_Min.TabIndex = 38;
            this.label_Spe_Min.Text = "0";
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 215);
            this.Controls.Add(this.label_Spe_Ave);
            this.Controls.Add(this.label_Spe_Max);
            this.Controls.Add(this.label_Spe_Min);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label_Pre_Ave);
            this.Controls.Add(this.label_Pre_Max);
            this.Controls.Add(this.label_Pre_Min);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_Str_Ave);
            this.Controls.Add(this.label_Str_Max);
            this.Controls.Add(this.label_Str_Min);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_Dis_Max);
            this.Controls.Add(this.label_Dis_Min);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTime_Max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTime_Min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "FormCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分析";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxTime_Min;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxTime_Max;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX button_calc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Dis_Min;
        private System.Windows.Forms.Label label_Dis_Max;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_Str_Ave;
        private System.Windows.Forms.Label label_Str_Max;
        private System.Windows.Forms.Label label_Str_Min;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Pre_Ave;
        private System.Windows.Forms.Label label_Pre_Max;
        private System.Windows.Forms.Label label_Pre_Min;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_Spe_Ave;
        private System.Windows.Forms.Label label_Spe_Max;
        private System.Windows.Forms.Label label_Spe_Min;
    }
}