using DevComponents.DotNetBar;
using HslCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TASITJ_3005
{
   
    public partial class FormStartSet : Office2007Form
    {
        public delegate void returnvalue(string str);
        public  returnvalue ReturnValue;
        public FormStartSet()
        {
            this.EnableGlass = false;
            
            InitializeComponent();

            textBoxX_Produce_name.Text = Global.Produce_name;
            if (Global.Produce_type != null)
            {
                comboBox_Type.Text = Global.Produce_type;
            }
            else comboBox_Type.Text = "100:1";

            if (Global.Kistler_ProNum == null)
            {
                Global.Kistler_ProNum = "0";
            }
           Text_Kistler_ProNum.Text = Global.Kistler_ProNum;
            
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (textBoxX_Produce_name.Text.Trim() == "" || textBoxX_Produce_name.Text.Trim() == null)
            {
                MessageBoxEx.Show("样品名称不能为空");
                return;
            }

            int pressnum = int.Parse(Text_Kistler_ProNum.Text);
            if (pressnum >= 128)
            {
                MessageBoxEx.Show("程序号输入错误");
                return;
            }
            OperateResult<bool> read = Global.siemensTcpNet.ReadBool("DB67.0");
            //if (read.IsSuccess == false)
            if (read.IsSuccess == true)
            {
                MessageBoxEx.Show("PLC写入参数失败");
                return;
            }else
            {
                if (read.Content)
                {
                    MessageBoxEx.Show("请在手动模式下进行操作");
                    return;
                }
            }
            OperateResult write1 = Global.siemensTcpNet.Write("DB69.2", (byte)pressnum);
            //if (write1.IsSuccess == false)
            if (write1.IsSuccess == true)
            {
                MessageBoxEx.Show("PLC写入参数失败");
                return;
            }
            OperateResult write2 = Global.siemensTcpNet.Write("DB69.3", (byte)pressnum);
            //if (write2.IsSuccess == false)
            if (write2.IsSuccess == true)
            {
                MessageBoxEx.Show("PLC写入参数失败");
                return;
            }


            Global.Produce_name = textBoxX_Produce_name.Text;
            Global.Produce_type = comboBox_Type.Text;
            Global.Kistler_ProNum = Text_Kistler_ProNum.Text;
            Global.Produce_Remarks = textBoxX_Remarks.Text;



            ReturnValue("停  止");
            Close();
        }

        private void Text_PressNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }
    }
}
