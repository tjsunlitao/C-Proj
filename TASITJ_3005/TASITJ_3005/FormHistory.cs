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
    public partial class FormHistory : Office2007Form
    {
        public FormHistory()
        {
            this.EnableGlass = false;
            InitializeComponent();
            this.groupBox1.Paint += groupBox_Paint;
            this.groupBox2.Paint += groupBox_Paint;
            dateTimeInput1.Value = DateTime.Now;
            dateTimeInput2.Value = DateTime.Now;
        }

        void groupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox gBox = (GroupBox)sender;

            e.Graphics.Clear(gBox.BackColor);
            e.Graphics.DrawString(gBox.Text, gBox.Font, Brushes.Black, 10, 1);
            var vSize = e.Graphics.MeasureString(gBox.Text, gBox.Font);
            e.Graphics.DrawLine(Pens.Black, 1, vSize.Height / 2, 8, vSize.Height / 2);
            e.Graphics.DrawLine(Pens.Black, vSize.Width + 8, vSize.Height / 2, gBox.Width - 2, vSize.Height / 2);
            e.Graphics.DrawLine(Pens.Black, 1, vSize.Height / 2, 1, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.Black, 1, gBox.Height - 2, gBox.Width - 2, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.Black, gBox.Width - 2, vSize.Height / 2, gBox.Width - 2, gBox.Height - 2);
        }

        private void button_Seach_Click(object sender, EventArgs e)
        {
            string date1 = dateTimeInput1.Value.ToString();
            string date2 = dateTimeInput2.Value.ToString();
            string sql1 = "SELECT Product_Name,Product_PressNum,Product_Type,Product_Remarks,CreateTime FROM (select * from Product_Message where Id in (select min(Id) from Product_Message group by CreateTime))as A WHERE CreateTime BETWEEN '" + date1 + "' AND '" + date2 + "'";
           // sql1 = sql1 + "in ()";
            DataTable dt = DbHelper.Instance.CreateDataTable(sql1);
            this.dataGridViewX1.DataSource = dt.DefaultView;
           // MessageBox.Show(dt.Rows[0][4].ToString());
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX1.RowCount > 0)
            {
                int a = dataGridViewX1.SelectedRows[0].Index;
                DateTime svalue = (DateTime)dataGridViewX1.Rows[a].Cells[4].Value;
               // MessageBox.Show(dt.ToString("yyyy-MM-dd HH:mm:ss"));
               // MessageBox.Show(dataGridViewX1.Rows[a].Cells[4].Value.ToString("yyyy-MM-dd HH:mm:ss"));
               // DateTime svalue = DateTime.Parse(dataGridViewX1.Rows[a].Cells[4].Value.ToString());
                //string svalue = "2019/07-06 10:39:33.990";
                // svalue.Replace("/", "-");
                string aaa = svalue.ToString("yyyy-MM-dd HH:mm:ss");
                FormHistoryChart f = new FormHistoryChart();
                f.Tag = aaa;
                f.ShowDialog();
            }

        }

        private void buttonItem_SingleDataExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount>0)
            {
                //MessageBox.Show(dataGridViewX1.SelectedRows[0].Index.ToString());
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    int a = dataGridViewX1.SelectedRows[0].Index;
                    DateTime svalue = DateTime.Parse(dataGridViewX1.Rows[a].Cells[4].Value.ToString());
                    string aaa = svalue.ToString("yyyy-MM-dd HH:mm:ss") + ".000";
                    string bbb = svalue.ToString("yyyyMMddHHmmss");
                    string sql1 = "SELECT * from Product_Message WHERE CreateTime = '" + aaa + "'ORDER BY Sort";
                    //string sql1 = "SELECT * from (select CONVERT(varchar(20), CreateTime, 120) as CreateTime,ProductData_Displacement,ProductData_Stress,ProductData_Pressure,ProductData_Speed,ProductData_Timer,Sort from Product_Message)as A WHERE CreateTime = '" + aaa + "'ORDER BY Sort";
                    DataTable dt = DbHelper.Instance.CreateDataTable(sql1);
                    dt.Columns.Remove("Id");
                    dt.Columns.Remove("CreateTime");
                    dt.Columns.Remove("Sort");
                    dt.Columns["ProductData_Displacement"].ColumnName = "位移";
                    dt.Columns["ProductData_Stress"].ColumnName = "压力";
                    dt.Columns["ProductData_Pressure"].ColumnName = "压强";
                    dt.Columns["ProductData_Speed"].ColumnName = "速度";
                    dt.Columns["ProductData_Timer"].ColumnName = "时间";
                    dt.Columns["Product_Name"].ColumnName = "样品名称";
                    dt.Columns["Product_PressNum"].ColumnName = "压机程序号";
                    dt.Columns["Product_Type"].ColumnName = "口模型号";
                    dt.Columns["Product_Remarks"].ColumnName = "备注";
                    CsvHelper.SaveCSV(dt, fbd.SelectedPath + "/" + bbb + ".csv");
                }
            }
            
        }

        private void buttonItem_SingleDataDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount > 0)
            {
                //MessageBox.Show(dataGridViewX1.SelectedRows[0].Index.ToString());
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    int a = dataGridViewX1.SelectedRows[0].Index;
                    DateTime svalue = DateTime.Parse(dataGridViewX1.Rows[a].Cells[4].Value.ToString());
                    string aaa = svalue.ToString("yyyy-MM-dd HH:mm:ss") + ".000";
                    string bbb = svalue.ToString("yyyyMMddHHmmss");

                    string sql1 = "SELECT * from Product_Message WHERE CreateTime = '" + aaa + "'ORDER BY Sort";
                    DataTable dt = DbHelper.Instance.CreateDataTable(sql1);
                    dt.Columns.Remove("Id");
                    dt.Columns.Remove("CreateTime");
                    dt.Columns.Remove("Sort");
                    dt.Columns["ProductData_Displacement"].ColumnName = "位移";
                    dt.Columns["ProductData_Stress"].ColumnName = "压力";
                    dt.Columns["ProductData_Pressure"].ColumnName = "压强";
                    dt.Columns["ProductData_Speed"].ColumnName = "速度";
                    dt.Columns["ProductData_Timer"].ColumnName = "时间";
                    dt.Columns["Product_Name"].ColumnName = "样品名称";
                    dt.Columns["Product_PressNum"].ColumnName = "压机程序号";
                    dt.Columns["Product_Type"].ColumnName = "口模型号";
                    dt.Columns["Product_Remarks"].ColumnName = "备注";
                    CsvHelper.SaveCSV(dt, fbd.SelectedPath + "/" + bbb + ".csv");

                    string sql2 = "DELETE from Product_Message WHERE (CreateTime = '" + aaa + "')";
                    DbHelper.Instance.ExecuteNonQuery(sql2);
                    dataGridViewX1.Rows.RemoveAt(a);
                }
            }
        }

        private void buttonItem_FullDataExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount > 0)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    for (int i=0;i< dataGridViewX1.RowCount;i++)
                    {
                        DateTime svalue = DateTime.Parse(dataGridViewX1.Rows[i].Cells[4].Value.ToString());
                        string aaa = svalue.ToString("yyyy-MM-dd HH:mm:ss") + ".000";
                        string bbb = svalue.ToString("yyyyMMddHHmmss");

                        string sql1 = "SELECT * from Product_Message WHERE CreateTime = '" + aaa + "'ORDER BY Sort";
                        DataTable dt = DbHelper.Instance.CreateDataTable(sql1);
                        dt.Columns.Remove("Id");
                        dt.Columns.Remove("CreateTime");
                        dt.Columns.Remove("Sort");
                        dt.Columns["ProductData_Displacement"].ColumnName = "位移";
                        dt.Columns["ProductData_Stress"].ColumnName = "压力";
                        dt.Columns["ProductData_Pressure"].ColumnName = "压强";
                        dt.Columns["ProductData_Speed"].ColumnName = "速度";
                        dt.Columns["ProductData_Timer"].ColumnName = "时间";
                        dt.Columns["Product_Name"].ColumnName = "样品名称";
                        dt.Columns["Product_PressNum"].ColumnName = "压机程序号";
                        dt.Columns["Product_Type"].ColumnName = "口模型号";
                        dt.Columns["Product_Remarks"].ColumnName = "备注";
                        CsvHelper.SaveCSV(dt, fbd.SelectedPath + "/" + bbb + ".csv");
                    }
                }
            }
        }

        private void buttonItem_FullDataDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount > 0)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    while (dataGridViewX1.RowCount != 0)
                    {
                        DateTime svalue = DateTime.Parse(dataGridViewX1.Rows[0].Cells[4].Value.ToString());
                        string aaa = svalue.ToString("yyyy-MM-dd HH:mm:ss") + ".000";
                        string bbb = svalue.ToString("yyyyMMddHHmmss");

                        string sql1 = "SELECT * from Product_Message WHERE CreateTime = '" + aaa + "'ORDER BY Sort";
                        DataTable dt = DbHelper.Instance.CreateDataTable(sql1);
                        dt.Columns.Remove("Id");
                        dt.Columns.Remove("CreateTime");
                        dt.Columns.Remove("Sort");
                        dt.Columns["ProductData_Displacement"].ColumnName = "位移";
                        dt.Columns["ProductData_Stress"].ColumnName = "压力";
                        dt.Columns["ProductData_Pressure"].ColumnName = "压强";
                        dt.Columns["ProductData_Speed"].ColumnName = "速度";
                        dt.Columns["ProductData_Timer"].ColumnName = "时间";
                        dt.Columns["Product_Name"].ColumnName = "样品名称";
                        dt.Columns["Product_PressNum"].ColumnName = "压机程序号";
                        dt.Columns["Product_Type"].ColumnName = "口模型号";
                        dt.Columns["Product_Remarks"].ColumnName = "备注";
                        CsvHelper.SaveCSV(dt, fbd.SelectedPath + "/" + bbb + ".csv");

                        string sql2 = "DELETE from Product_Message WHERE (CreateTime = '" + aaa + "')";
                        DbHelper.Instance.ExecuteNonQuery(sql2);
                        dataGridViewX1.Rows.RemoveAt(0);
                    }
                }
            }
        }
    }
}