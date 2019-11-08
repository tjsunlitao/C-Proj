using DevComponents.DotNetBar;
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
    public partial class FormCalc : Office2007Form
    {
        public FormCalc()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            double dDismin = 999;
            double dDismax = -999;
            double dave = 0;
            double dStrmin = 999;
            double dStrmax = -999;
            double dStrave = 0;
            double dPremin = 999;
            double dPremax = -999;
            double dPreave = 0;
            double dSpemin = 999;
            double dSpemax = -999;
            double dSpeave = 0;
            int num = 0;
            DataTable dt = Global.dt;
            for (int i = 0; i < Global.dt_kistler1.Rows.Count; i++)
            {
                //时间比较
               if (System.Convert.ToDouble(Global.dt.Rows[i][0].ToString()) >= System.Convert.ToDouble(textBoxTime_Min.Text)  && System.Convert.ToDouble(Global.dt.Rows[i][0].ToString()) <= System.Convert.ToDouble(textBoxTime_Max.Text))
               {
                    num = num + 1;
                    //位移比较
                    if (System.Convert.ToDouble(Global.dt.Rows[i][1].ToString()) > dDismax)
                    {
                        dDismax = System.Convert.ToDouble(Global.dt.Rows[i][1].ToString());
                    }
                    if (System.Convert.ToDouble(Global.dt.Rows[i][1].ToString()) < dDismin)
                    {
                        dDismin = System.Convert.ToDouble(Global.dt.Rows[i][1].ToString());
                    }
                    //压力比较
                    if (System.Convert.ToDouble(Global.dt.Rows[i][2].ToString()) > dStrmax)
                    {
                        dStrmax = System.Convert.ToDouble(Global.dt.Rows[i][2].ToString());
                    }
                    if (System.Convert.ToDouble(Global.dt.Rows[i][2].ToString()) < dStrmin)
                    {
                        dStrmin = System.Convert.ToDouble(Global.dt.Rows[i][2].ToString());
                    }
                    dStrave = dStrave + System.Convert.ToDouble(Global.dt.Rows[i][2].ToString());
                    //压强比较
                    if (System.Convert.ToDouble(Global.dt.Rows[i][3].ToString()) > dPremax)
                    {
                        dPremax = System.Convert.ToDouble(Global.dt.Rows[i][3].ToString());
                    }
                    if (System.Convert.ToDouble(Global.dt.Rows[i][3].ToString()) < dPremin)
                    {
                        dPremin = System.Convert.ToDouble(Global.dt.Rows[i][3].ToString());
                    }
                    dPreave = dPreave + System.Convert.ToDouble(Global.dt.Rows[i][3].ToString());
                    //速度比较
                    if (System.Convert.ToDouble(Global.dt.Rows[i][4].ToString()) > dSpemax)
                    {
                        dSpemax = System.Convert.ToDouble(Global.dt.Rows[i][4].ToString());
                    }
                    if (System.Convert.ToDouble(Global.dt.Rows[i][4].ToString()) < dSpemin)
                    {
                        dSpemin = System.Convert.ToDouble(Global.dt.Rows[i][4].ToString());
                    }
                    dSpeave = dSpeave + System.Convert.ToDouble(Global.dt.Rows[i][4].ToString());
                }
            }

            label_Dis_Min.Text = dDismin.ToString();
            label_Dis_Max.Text = dDismax.ToString();

            label_Str_Min.Text = dStrmin.ToString();
            label_Str_Max.Text = dStrmax.ToString();
            label_Str_Ave.Text = Math.Round((dStrave / num),5).ToString ();

            label_Pre_Min.Text = dPremin.ToString();
            label_Pre_Max.Text = dPremax.ToString();
            label_Pre_Ave.Text = Math.Round((dPreave / num), 5).ToString();

            label_Spe_Min.Text = dSpemin.ToString();
            label_Spe_Max.Text = dSpemax.ToString();
            label_Spe_Ave.Text = Math.Round((dSpeave / num), 2).ToString();

        }

        private void textBoxTime_Min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxTime_Max_KeyPress(object sender, KeyPressEventArgs e)
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
