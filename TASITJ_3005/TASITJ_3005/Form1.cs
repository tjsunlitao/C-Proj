using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TASITJ_3005
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable _actual = CsvHelper.OpenCSV(@"C:/1.csv");

            DirectoryInfo di = new DirectoryInfo(@"D:/test");
            DirectoryInfo[] dirs = di.GetDirectories();     //扫描文件夹

            //foreach (DirectoryInfo di1 in dirs)
            //{
            //    listBox1.Items.Add(di1.Name);
            //}

            FileInfo[] files = di.GetFiles("*.txt");                       //扫描文件 GetFiles("*.txt");可以实现扫描扫描txt文件 
            //foreach (FileInfo fi in files)
            //{
            //    listBox1.Items.Add(fi.Name);
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.SelectedPath = @"D:/Test";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = fbd.SelectedPath;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
    }
}
