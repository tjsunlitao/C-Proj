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
    public partial class FormHistoryChart : Office2007Form
    {
        public FormHistoryChart()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void FormHistoryChart_Load(object sender, EventArgs e)
        {
            DateTime aaa = DateTime.Now;
            //MessageBox.Show(Tag.ToString());

              string sql1 = "SELECT * from (select CONVERT(varchar(20), CreateTime, 120) as CreateTime,ProductData_Displacement,ProductData_Stress,ProductData_Pressure,ProductData_Speed,ProductData_Timer,Sort from Product_Message)as A WHERE CreateTime = '" + Tag.ToString() + "'ORDER BY Sort";
            //string sql1 = "select CONVERT(varchar(20), CreateTime, 120) as CreateTime,ProductData_Displacement,ProductData_Stress,ProductData_Pressure,ProductData_Speed,ProductData_Timer from Product_Message";
            DataTable dt = DbHelper.Instance.CreateDataTable(sql1);
            //dt.DefaultView.Sort = " Sort asc ";
            DevComponents.DotNetBar.Charts.ChartXy my_chart = (DevComponents.DotNetBar.Charts.ChartXy)chartControl1.ChartPanel.ChartContainers[0];
            my_chart.ChartSeries[0].SeriesPoints.Clear();
            my_chart.ChartSeries[1].SeriesPoints.Clear();
            my_chart.ChartSeries[2].SeriesPoints.Clear();
            my_chart.ChartSeries[3].SeriesPoints.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint1 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                seriesPoint1.ValueX = System.Convert.ToDouble(dt.Rows[i][5].ToString());
                seriesPoint1.ValueY = new object[] { ((object)(System.Convert.ToDouble(dt.Rows[i][1].ToString()))) };
                my_chart.ChartSeries[0].SeriesPoints.Add(seriesPoint1);

                DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint2 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                seriesPoint2.ValueX = System.Convert.ToDouble(dt.Rows[i][5].ToString());
                seriesPoint2.ValueY = new object[] { ((object)(System.Convert.ToDouble(dt.Rows[i][2].ToString()))) };
                my_chart.ChartSeries[1].SeriesPoints.Add(seriesPoint2);

                DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint3 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                seriesPoint3.ValueX = System.Convert.ToDouble(dt.Rows[i][5].ToString());
                seriesPoint3.ValueY = new object[] { ((object)(System.Convert.ToDouble(dt.Rows[i][3].ToString()))) };
                my_chart.ChartSeries[2].SeriesPoints.Add(seriesPoint3);

                DevComponents.DotNetBar.Charts.SeriesPoint seriesPoint4 = new DevComponents.DotNetBar.Charts.SeriesPoint();
                seriesPoint4.ValueX = System.Convert.ToDouble(dt.Rows[i][5].ToString());
                seriesPoint4.ValueY = new object[] { ((object)(System.Convert.ToDouble(dt.Rows[i][4].ToString()))) };
                my_chart.ChartSeries[3].SeriesPoints.Add(seriesPoint4);

            }

        }

        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.Charts.ChartXy my_chart = (DevComponents.DotNetBar.Charts.ChartXy)chartControl1.ChartPanel.ChartContainers[0];
            // my_chart.MinContentSize = (my_chart.MinContentSize.Width , my_chart.MinContentSize.Height);

            System.Drawing.Size t = my_chart.MinContentSize;
            t.Width = 100 + slider1.Value;
            t.Height = 100 + slider1.Value;
            my_chart.MinContentSize = t;
        }
    }
}
