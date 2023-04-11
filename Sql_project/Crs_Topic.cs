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
    public partial class Crs_Topic : Form
    {
        Examination_System_Final_ProjectEntities2 Entity;
        public string Crs_Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        int Crs_ID;
        public Crs_Topic()
        {
            InitializeComponent();
            Entity = new Examination_System_Final_ProjectEntities2();
        }

        private void Crs_Topic_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            var result = (from S in Entity.Courses
                          where S.Course_Name == Crs_Name
                          select S).FirstOrDefault();
            if (result != null)
            {
                Crs_ID = result.Course_ID;
            }
            int crs_no = Crs_ID;
            this.crs_TopicsTableAdapter1.Fill(this.dataSet22.Crs_Topics, crs_no);
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dataSet22.Tables[0]));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] PdfBytes = reportViewer1.LocalReport.Render("PDF");
            string FilePath = "D:\\ITI\\SQL\\Report2.pdf";
            using (FileStream FS = new FileStream(FilePath, FileMode.Create))
            {
                FS.Write(PdfBytes, 0, PdfBytes.Length);
            }
            MessageBox.Show("Report Saved Successfully");
        }
    }
}
