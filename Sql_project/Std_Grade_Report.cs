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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sql_project
{
    public partial class Std_Grade_Report : Form
    {
        int id;
        Examination_System_Final_ProjectEntities2 Entity;
        public string Student_ID
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Std_Grade_Report()
        {
            InitializeComponent();
            Entity = new Examination_System_Final_ProjectEntities2();
        }

        private void Std_Grade_Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            id = int.Parse(Student_ID);
            var result = (from S in Entity.Students
                          where S.St_ID == id
                          select S).FirstOrDefault();
            if (result != null)
            {
                textBox1.Text = result.St_ID.ToString();
            }
            int Std_ID = int.Parse(textBox1.Text);
            this.reportViewer1.RefreshReport();
            this.std_GardeTableAdapter1.Fill(this.dataSet1.Std_Garde,Std_ID);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataSet1.Tables[0]));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] PdfBytes = reportViewer1.LocalReport.Render("PDF");
            string FilePath = "D:\\ITI\\SQL\\Report1.pdf";
            using (FileStream FS = new FileStream(FilePath, FileMode.Create))
            {
                FS.Write(PdfBytes, 0, PdfBytes.Length);
            }
            MessageBox.Show("Report Saved Successfully");
        }
    }
}
