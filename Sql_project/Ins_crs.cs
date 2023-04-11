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
    public partial class Ins_crs : Form
    {
        public Ins_crs()
        {
            InitializeComponent();
        }

        private void Ins_crs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comboBox_Ins_ID_dataset.Instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter.Fill(this.comboBox_Ins_ID_dataset.Instructor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ins_ID = int.Parse(comboBox1.Text);
            using (Examination_System_Final_ProjectEntities2 Entity = new Examination_System_Final_ProjectEntities2())
            {
                insCrsDataSet1BindingSource.DataSource = Entity.Ins_Crs(Ins_ID);
                this.reportViewer1.RefreshReport();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] PdfBytes = reportViewer1.LocalReport.Render("PDF");
            string FilePath = "D:\\ITI\\SQL\\Report5.pdf";
            using (FileStream FS = new FileStream(FilePath, FileMode.Create))
            {
                FS.Write(PdfBytes, 0, PdfBytes.Length);
            }
            MessageBox.Show("Report Saved Successfully");
        }
    }
}
