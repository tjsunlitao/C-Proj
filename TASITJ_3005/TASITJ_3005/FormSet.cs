using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASITJ_3005
{
    public partial class FormSet : Office2007Form
    {
        public FormSet()
        {
            this.EnableGlass = false;
            InitializeComponent();
            text_Path_1.Text = Global.KistlerDataReadAddress1;
            text_Path_2.Text = Global.KistlerDataReadAddress2;
            text_Path_3.Text = Global.KistlerDataTargetAddress1;
            text_Path_4.Text = Global.KistlerDataTargetAddress2;
        }

        private void button_Sel_Path_1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.text_Path_1.Text = fbd.SelectedPath;
            }
        }

        private void button_Sel_Path_2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.text_Path_2.Text = fbd.SelectedPath;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Global.KistlerDataReadAddress1 = text_Path_1.Text;
            Global.KistlerDataReadAddress2 = text_Path_2.Text;
            Global.KistlerDataTargetAddress1 = text_Path_3.Text;
            Global.KistlerDataTargetAddress2 = text_Path_4.Text;

            string str = System.Windows.Forms.Application.StartupPath;
            OperateIniFile.WriteIniData("Path", " KistlerDataReadAddress1", Global.KistlerDataReadAddress1, str + "\\Config.ini");
            OperateIniFile.WriteIniData("Path", " KistlerDataReadAddress2", Global.KistlerDataReadAddress2, str + "\\Config.ini");
            OperateIniFile.WriteIniData("Path", " KistlerDataTargetAddress1", Global.KistlerDataTargetAddress1, str + "\\Config.ini");
            OperateIniFile.WriteIniData("Path", " KistlerDataTargetAddress2", Global.KistlerDataTargetAddress2, str + "\\Config.ini");
            MessageBoxEx.Show("保存设置成功");
            Close();
        }

        private void button_Sel_Path_3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.text_Path_3.Text = fbd.SelectedPath;
            }
        }

        private void button_Sel_Path_4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.text_Path_4.Text = fbd.SelectedPath;
            }
        }
    }
}
