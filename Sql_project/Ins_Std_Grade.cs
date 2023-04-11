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
    public partial class Ins_Std_Grade : Form
    {
        Examination_System_Final_ProjectEntities2 Ent;
        public Ins_Std_Grade()
        {
            InitializeComponent();
            Ent = new Examination_System_Final_ProjectEntities2();
        }

        private void Ins_Std_Grade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'std_ID_Dataset.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.std_ID_Dataset.Student);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Std_ID = int.Parse(comboBox1.Text);
            using(Examination_System_Final_ProjectEntities2 Entity = new Examination_System_Final_ProjectEntities2())
            {
                insStdGradeDataSet1BindingSource.DataSource = Entity.Std_Garde(Std_ID);
                this.reportViewer1.RefreshReport();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] PdfBytes = reportViewer1.LocalReport.Render("PDF");
            string FilePath = "D:\\ITI\\SQL\\Report4.pdf";
            using (FileStream FS = new FileStream(FilePath, FileMode.Create))
            {
                FS.Write(PdfBytes, 0, PdfBytes.Length);
            }
            MessageBox.Show("Report Saved Successfully");
        }
    }
}
