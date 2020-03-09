using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Charts;
using DevComponents.DotNetBar.Charts.Style;
using HslCommunication;
using HslCommunication.Profinet.Siemens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TASITJ_3005.FormStartSet;

namespace TASITJ_3005
{

    public partial class FormMain : Office2007Form
    {

        public FormMain()
        {

            
            
            string str = System.Windows.Forms.Application.StartupPath;
            Global.PLC_IP_Adress = OperateIniFile.ReadIniData("Setting", " PLC_IP", "", str + "\\Config.ini");
            
            IPAddress address;
            bool flag = !IPAddress.TryParse(Global.PLC_IP_Adress, out address);
            if (flag)
            {
                MessageBox.Show("PLC IP地址配置不正确");
                Close();
            }

            Global.siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1200);
            Global.siemensTcpNet.IpAddress = Global.PLC_IP_Adress;
            Global.siemensTcpNet.ConnectTimeOut = 500;
            Global.connect = Global.siemensTcpNet.ConnectServer();


            this.EnableGlass = false;
            InitializeComponent();

            Global.KistlerDataReadAddress1 = OperateIniFile.ReadIniData("Path", " KistlerDataReadAddress1", "", str + "\\Config.ini");
            Global.KistlerDataReadAddress2 = OperateIniFile.ReadIniData("Path", " KistlerDataReadAddress2", "", str + "\\Config.ini");
            Global.KistlerDataTargetAddress1 = OperateIniFile.ReadIniData("Path", " KistlerDataTargetAddress1", "", str + "\\Config.ini");
            Global.KistlerDataTargetAddress2 = OperateIniFile.ReadIniData("Path", " KistlerDataTargetAddress2", "", str + "\\Config.ini");
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            FormSet f = new FormSet();
            f.ShowDialog();
        }

        private void button_History_Click(object sender, EventArgs e)
        {
            FormHistory f = new FormHistory();
            f.ShowDialog();
        }



        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.Charts.ChartXy my_chart = (DevComponents.DotNetBar.Charts.ChartXy)chartControl1.ChartPanel.ChartContainers[0];
            // my_chart.MinContentSize = (my_chart.MinContentSize.Width , my_chart.MinContentSize.Height);

            System.Drawing.Size t = my_chart.MinContentSize;
            t.Width =100 + slider1.Value;
            t.Height = 100 + slider1.Value;
            my_chart.MinContentSize = t;
        }

        private void Process()
        {
            while(true)
            {
                DirectoryInfo di1 = new DirectoryInfo(Global.KistlerDataReadAddress1);
                DirectoryInfo[] dirs1 = di1.GetDirectories();
                FileInfo[] files1 = di1.GetFiles("*.csv");
                if (files1.Count() > 1)
                {
                    foreach (FileInfo fi in files1)
                    {
                        File.Move(fi.FullName, Global.KistlerDataTargetAddress1 + "\\" + fi.Name);
                    }
                    return;
                }

                DirectoryInfo di2 = new DirectoryInfo(Global.KistlerDataReadAddress2);
                DirectoryInfo[] dirs2 = di2.GetDirectories();
                FileInfo[] files2 = di2.GetFiles("*.csv");
                if (files2.Count() > 1)
                {
                    foreach (FileInfo fi in files2)
                    {
                        File.Move(fi.FullName, Global.KistlerDataTargetAddress2 + "\\" + fi.Name);
                    }
                    return;
                }


                if (files1.Count() == 1 && files2.Count() == 1)
                {

                    //Global.dt_kistler1.Clear();
                    //Global.dt_kistler2.Clear();

                    Global.dt_kistler1 = CsvHelper.OpenCSV(files1[0].FullName);
                    Global.dt_kistler2 = CsvHelper.OpenCSV(files2[0].FullName);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("时间", typeof(double)); //数据类型为 浮点数
                    dt.Columns.Add("位移", typeof(double)); //数据类型为 浮点数
                    dt.Columns.Add("压力", typeof(double)); //数据类型为 浮点数
                    dt.Columns.Add("压强", typeof(double)); //数据类型为 浮点数
                    dt.Columns.Add("速度", typeof(double)); //数据类型为 浮点数

                    string Copy_Name = DateTime.Now.ToString("yyyyMMddHHmmss");

                    //表格另存为地址，看看以后是否需要用到
                    //CsvHelper.SaveCSV(dt_kistler1, Global.KistlerDataTargetAddress1 + "\\" + Copy_Name + ".csv");
                    //CsvHelper.SaveCSV(dt_kistler2, Global.KistlerDataTargetAddress2 + "\\" + Copy_Name + ".csv");

                    File.Move(files1[0].FullName, Global.KistlerDataTargetAddress1 + "\\" + files1[0].Name);
                    File.Move(files2[0].FullName, Global.KistlerDataTargetAddress2 + "\\" + files2[0].Name);

                    DevComponents.DotNetBar.Charts.ChartXy my_chart = (DevComponents.DotNetBar.Charts.ChartXy)chartControl1.ChartPanel.ChartContainers[0];
                    my_chart.ChartSeries[0].SeriesPoints.Clear();
                    my_chart.ChartSeries[1].SeriesPoints.Clear();
                    my_chart.ChartSeries[2].SeriesPoints.Clear();
                    my_chart.ChartSeries[3].SeriesPoints.Clear();
                    double d_displacement_1 = 0;
                    double d_displacement_2 = 0;
                    double d_time_1 = 0;
                    double d_time_2 = 0;
                    DateTime creattime = System.DateTime.Now;
                    string s_creattime = DateTime.Now.ToString() + ".000";

                    for (int i = 0; i < Global.dt_kistler1.Rows.Count; i++)
                    {
                        DataRow dr2 = dt.NewRow();
                        DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint1 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                        seriesPoint1.ValueX = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                        seriesPoint1.ValueY = new object[] { ((object)(System.Convert.ToDouble(Global.dt_kistler1.Rows[i][1].ToString()))) };
                        my_chart.ChartSeries[0].SeriesPoints.Add(seriesPoint1);
                        dr2[0] = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                        dr2[1] = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][1].ToString());

                        DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint2 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                        seriesPoint2.ValueX = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                        seriesPoint2.ValueY = new object[] { ((object)(System.Convert.ToDouble(Global.dt_kistler1.Rows[i][2].ToString()))) };
                        my_chart.ChartSeries[1].SeriesPoints.Add(seriesPoint2);
                        dr2[2] = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][2].ToString());

                        DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint3 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                        dr2[3] = 0;
                        if (i < Global.dt_kistler2.Rows.Count)
                        {
                            seriesPoint3.ValueX = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                            seriesPoint3.ValueY = new object[] { ((object)(System.Convert.ToDouble(Global.dt_kistler2.Rows[i][2].ToString()))) };
                            my_chart.ChartSeries[2].SeriesPoints.Add(seriesPoint3);
                            dr2[3] = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][3].ToString());
                        }

                        DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint4 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                        dr2[4] = 0;
                        if (i < Global.dt_kistler1.Rows.Count)
                        {
                            seriesPoint4.ValueX = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                            d_displacement_1 = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][1].ToString());
                            d_time_1 = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                            if (i == 0)
                            {
                                d_displacement_2 = 0;
                                d_time_2 = 0;
                            }
                            else
                            {
                                d_displacement_2 = System.Convert.ToDouble(Global.dt_kistler1.Rows[i - 1][1].ToString());
                                d_time_2 = System.Convert.ToDouble(Global.dt_kistler1.Rows[i - 1][0].ToString());
                            }
                            double dresult = Math.Abs((d_displacement_1 - d_displacement_2)) / (d_time_1 - d_time_2);
                            seriesPoint4.ValueY = new object[] { ((object)dresult) };
                            my_chart.ChartSeries[3].SeriesPoints.Add(seriesPoint4);
                            dr2[4] = dresult;
                        }
                        dt.Rows.Add(dr2);
                        string sql = string.Format("insert into Product_Message(Id,Product_Name,Product_PressNum,Product_Type,Product_Remarks,ProductData_Displacement,ProductData_Stress,ProductData_Pressure,ProductData_Speed,ProductData_Timer,CreateTime,Sort) values(@Id,@Product_Name,@Product_PressNum,@Product_Type,@Product_Remarks,@ProductData_Displacement,@ProductData_Stress,@ProductData_Pressure,@ProductData_Speed,@ProductData_Timer,@CreateTime,@Sort)");
                        string id = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                        id = id + i.ToString();
                        float aaa = float.Parse(seriesPoint1.ValueY[0].ToString());

                        DbHelper.Instance.ExecuteNonQuery(sql,
                            new SqlParameter("Id", id),
                            new SqlParameter("Product_Name", Global.Produce_name),
                            new SqlParameter("Product_PressNum", Global.Kistler_ProNum),
                            new SqlParameter("Product_Type", Global.Produce_type),
                            new SqlParameter("Product_Remarks", Global.Produce_Remarks),
                            new SqlParameter("ProductData_Displacement", float.Parse(seriesPoint1.ValueY[0].ToString())),
                            new SqlParameter("ProductData_Stress", float.Parse(seriesPoint2.ValueY[0].ToString())),
                            new SqlParameter("ProductData_Pressure", float.Parse(seriesPoint3.ValueY[0].ToString())),
                            new SqlParameter("ProductData_Speed", float.Parse(seriesPoint4.ValueY[0].ToString())),
                            new SqlParameter("ProductData_Timer", float.Parse(seriesPoint1.ValueX.ToString())),
                            new SqlParameter("Sort", i),
                            new SqlParameter("CreateTime", s_creattime)
                          
                            
                            ) ;
                    }
                    Global.dt = dt;
                }
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DirectoryInfo di1 = new DirectoryInfo(Global.KistlerDataReadAddress1);
            DirectoryInfo[] dirs1 = di1.GetDirectories();
            FileInfo[] files1 = di1.GetFiles("*.csv");
            if (files1.Count() > 1)
            {
                foreach (FileInfo fi in files1)
                {
                    File.Move(fi.FullName, Global.KistlerDataTargetAddress1 + "\\"+ fi.Name);
                }
                return;
            }

            DirectoryInfo di2 = new DirectoryInfo(Global.KistlerDataReadAddress2);
            DirectoryInfo[] dirs2 = di2.GetDirectories();
            FileInfo[] files2 = di2.GetFiles("*.csv");
            if (files2.Count() > 1)
            {
                foreach (FileInfo fi in files2)
                {
                    File.Move(fi.FullName, Global. KistlerDataTargetAddress2 + "\\" + fi.Name);
                }
                return;
            }

            if (files1.Count() == 1 && files2.Count() == 1)
            {

                //Global.dt_kistler1.Clear();
                //Global.dt_kistler2.Clear();

                Global.dt_kistler1 = CsvHelper.OpenCSV(files1[0].FullName);
                Global.dt_kistler2 = CsvHelper.OpenCSV(files2[0].FullName);

                DataTable dt = new DataTable();
                dt.Columns.Add("时间", typeof(double)); //数据类型为 浮点数
                dt.Columns.Add("位移", typeof(double)); //数据类型为 浮点数
                dt.Columns.Add("压力", typeof(double)); //数据类型为 浮点数
                dt.Columns.Add("压强", typeof(double)); //数据类型为 浮点数
                dt.Columns.Add("速度", typeof(double)); //数据类型为 浮点数

                string Copy_Name = DateTime.Now.ToString("yyyyMMddHHmmss");

                //表格另存为地址，看看以后是否需要用到
                //CsvHelper.SaveCSV(dt_kistler1, Global.KistlerDataTargetAddress1 + "\\" + Copy_Name + ".csv");
                //CsvHelper.SaveCSV(dt_kistler2, Global.KistlerDataTargetAddress2 + "\\" + Copy_Name + ".csv");

                File.Move(files1[0].FullName, Global.KistlerDataTargetAddress1 + "\\" + files1[0].Name);
                File.Move(files2[0].FullName, Global.KistlerDataTargetAddress2 + "\\" + files2[0].Name);

                DevComponents.DotNetBar.Charts.ChartXy my_chart = (DevComponents.DotNetBar.Charts.ChartXy)chartControl1.ChartPanel.ChartContainers[0];
                my_chart.ChartSeries[0].SeriesPoints.Clear();
                my_chart.ChartSeries[1].SeriesPoints.Clear();
                my_chart.ChartSeries[2].SeriesPoints.Clear();
                my_chart.ChartSeries[3].SeriesPoints.Clear();
                double d_displacement_1 = 0;
                double d_displacement_2 = 0;
                double d_time_1 = 0;
                double d_time_2 = 0;
                DateTime creattime = System.DateTime.Now;
                string s_creattime = DateTime.Now.ToString() + ".000";

                for (int i = 0; i < Global.dt_kistler1.Rows.Count; i++)
                {
                    DataRow dr2 = dt.NewRow();
                    DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint1 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                    seriesPoint1.ValueX = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                    seriesPoint1.ValueY = new object[] { ((object)(System.Convert.ToDouble(Global.dt_kistler1.Rows[i][1].ToString()))) };
                    my_chart.ChartSeries[0].SeriesPoints.Add(seriesPoint1);
                    dr2[0] = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                    dr2[1] = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][1].ToString());

                    DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint2 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                    seriesPoint2.ValueX = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                    seriesPoint2.ValueY = new object[] { ((object)(System.Convert.ToDouble(Global.dt_kistler1.Rows[i][2].ToString()))) };
                    my_chart.ChartSeries[1].SeriesPoints.Add(seriesPoint2);
                    dr2[2] = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][2].ToString());

                    DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint3 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                    dr2[3] = 0;
                    if (i < Global.dt_kistler2.Rows.Count)
                    {
                        seriesPoint3.ValueX = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                        seriesPoint3.ValueY = new object[] { ((object)(System.Convert.ToDouble(Global.dt_kistler2.Rows[i][2].ToString()))) };
                        my_chart.ChartSeries[2].SeriesPoints.Add(seriesPoint3);
                        dr2[3] = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][3].ToString());
                    }

                    DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint4 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                    dr2[4] = 0;
                    if (i < Global.dt_kistler1.Rows.Count)
                    {
                        seriesPoint4.ValueX = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                        d_displacement_1 = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][1].ToString());
                        d_time_1 = System.Convert.ToDouble(Global.dt_kistler1.Rows[i][0].ToString());
                        if (i == 0)
                        {
                            d_displacement_2 = 0;
                            d_time_2 = 0;
                        }else
                        {
                            d_displacement_2 = System.Convert.ToDouble(Global.dt_kistler1.Rows[i - 1][1].ToString());
                            d_time_2 = System.Convert.ToDouble(Global.dt_kistler1.Rows[i - 1][0].ToString());
                        }
                        double dresult = Math.Abs((d_displacement_1 - d_displacement_2)) / (d_time_1 - d_time_2);
                        seriesPoint4.ValueY = new object[] { ((object)dresult) };
                        my_chart.ChartSeries[3].SeriesPoints.Add(seriesPoint4);
                        dr2[4] = dresult;
                    }
                    dt.Rows.Add(dr2);
                    string sql = string.Format("insert into Product_Message(Id,Product_Name,Product_PressNum,Product_Type,Product_Remarks,ProductData_Displacement,ProductData_Stress,ProductData_Pressure,ProductData_Speed,ProductData_Timer,CreateTime,Sort) values(@Id,@Product_Name,@Product_PressNum,@Product_Type,@Product_Remarks,@ProductData_Displacement,@ProductData_Stress,@ProductData_Pressure,@ProductData_Speed,@ProductData_Timer,@CreateTime,@Sort)");
                    string id = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    id = id + i.ToString();
                    float aaa = float.Parse(seriesPoint1.ValueY[0].ToString());

                    DbHelper.Instance.ExecuteNonQuery(sql, 
                        new SqlParameter("Id", id), 
                        new SqlParameter("Product_Name", Global.Produce_name), 
                        new SqlParameter("Product_PressNum", Global.Kistler_ProNum), 
                        new SqlParameter("Product_Type", Global.Produce_type), 
                        new SqlParameter("Product_Remarks", Global.Produce_Remarks),
                        new SqlParameter("ProductData_Displacement", float.Parse(seriesPoint1.ValueY[0].ToString())),
                        new SqlParameter("ProductData_Stress", float.Parse(seriesPoint2.ValueY[0].ToString())),
                        new SqlParameter("ProductData_Pressure", float.Parse(seriesPoint3.ValueY[0].ToString())),
                        new SqlParameter("ProductData_Speed", float.Parse(seriesPoint4.ValueY[0].ToString())),
                        new SqlParameter("ProductData_Timer", float.Parse(seriesPoint1.ValueX.ToString())),
                        new SqlParameter("Sort",i),
                        new SqlParameter("CreateTime", s_creattime));
                }
                Global.dt = dt;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DirectoryInfo di1 = new DirectoryInfo(Global.KistlerDataReadAddress1);
            DirectoryInfo[] dirs1 = di1.GetDirectories();
            FileInfo[] files1 = di1.GetFiles("*.csv");

            DirectoryInfo di2 = new DirectoryInfo(Global.KistlerDataReadAddress2);
            DirectoryInfo[] dirs2 = di2.GetDirectories();
            FileInfo[] files2 = di2.GetFiles("*.csv");

            if (files1.Count() == 1 && files2.Count() == 1)
            {
                return;
            }else
            {
                foreach (FileInfo fi in files1)
                {
                    File.Move(fi.FullName, Global.KistlerDataTargetAddress1 + "\\" + fi.Name);
                }
                foreach (FileInfo fi in files2)
                {
                    File.Move(fi.FullName, Global.KistlerDataTargetAddress2 + "\\" + fi.Name);
                }
            }

            thread = new Thread(new ThreadStart(UpdateUI)) { IsBackground = true };
            thread.Start();
        }
        private void UpdateUI()
        {
            while (true)
            {
                OperateResult<bool> read = Global.siemensTcpNet.ReadBool("I0");
                if (read.IsSuccess)
                {
                    Invoke(new Action<bool>(m =>
                    {
                        labelX_PLC_State.Text = "PLC连接状态: 已连接";
                    }),true);
                    Global.siemensTcpNet.Write("DB69.0", (short)1);
                }
                else
                {
                    Invoke(new Action<bool>(m =>
                    {
                        labelX_PLC_State.Text = "PLC连接状态: 未连接";
                    }),true);
                }
                Thread.Sleep(1000);
            }
        }
        private Thread thread;

        private void button_Start_Click(object sender, EventArgs e)
        {


            if (button_Start.Text == "开  始")
            {
                FormStartSet f = new FormStartSet();
                f.ReturnValue += new returnvalue(showvalue);
               
                f.ShowDialog();
              
            }
            else
            {
                button_Start.Text = "开  始";
                // timer1.Enabled = false;

                Global.t1.Abort();
            }
        }

        private void showvalue(string str)
        {
            button_Start.Text = str;
            if (str == "停  止")
            {
               // timer1.Enabled = true;
                
                Global.t1 = new Thread(Process) { IsBackground = true };
                Global.t1.Start();
            }
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            FormCalc f = new FormCalc();
            f.ShowDialog();
        }

        private void bar1_ItemClick(object sender, EventArgs e)
        {

        }
    }

}
