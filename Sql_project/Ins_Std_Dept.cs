using Microsoft.Reporting.WinForms;
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

namespace Sql_project
{
    public partial class Ins_Std_Dept : Form
    {
        public Ins_Std_Dept()
        {
            InitializeComponent();
        }

        private void Ins_Std_Dept_Load(object sender, EventArgs e)
        {
            ComboBoxFill();
            
        }
        public void ComboBoxFill()
        {
            comboBox1.Items.Add("dot net");
            comboBox1.Items.Add("Sys_Admin");
            comboBox1.Items.Add("Com_Sci");
            comboBox1.Items.Add("AI");
            comboBox1.Items.Add("Open_src");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "dot net")
            {
                textBox1.Text = "1";
            }
            else if (comboBox1.Text == "Sys_Admin")
            {
                textBox1.Text = "2";
            }
            else if (comboBox1.Text == "Com_Sci")
            {
                textBox1.Text = "3";
            }
            else if (comboBox1.Text == "AI")
            {
                textBox1.Text = "4";
            }
            else if (comboBox1.Text == "Open_src")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dept_ID = int.Parse(textBox1.Text);
            this.std_DeptTableAdapter.Fill(this.dataSet4.Std_Dept, Dept_ID);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet4", dataSet4.Tables[3]));
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] PdfBytes = reportViewer1.LocalReport.Render("PDF");
            string FilePath = "D:\\ITI\\SQL\\Report.pdf";
            using (FileStream FS = new FileStream(FilePath, FileMode.Create))
            {
                FS.Write(PdfBytes, 0, PdfBytes.Length);
            }
            MessageBox.Show("Report Saved Successfully");
        }
    }
}
