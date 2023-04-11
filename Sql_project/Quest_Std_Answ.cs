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
    public partial class Quest_Std_Answ : Form
    {
        public Quest_Std_Answ()
        {
            InitializeComponent();
        }

        private void Quest_Std_Answ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Std_ID.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dS_Std_ID.Student);
            // TODO: This line of code loads data into the 'dS_Exam_ID.Exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.dS_Exam_ID.Exam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Exam_ID = int.Parse(comboBox1.Text);
            int Std_ID = int.Parse(comboBox2.Text);
            using (Examination_System_Final_ProjectEntities2 Entity = new Examination_System_Final_ProjectEntities2())
            {
                quesStdAnswerDataSet1BindingSource.DataSource = Entity.Ques_StdAnswer(Exam_ID, Std_ID);
                this.reportViewer1.RefreshReport();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] PdfBytes = reportViewer1.LocalReport.Render("PDF");
            string FilePath = "D:\\ITI\\SQL\\Report7.pdf";
            using (FileStream FS = new FileStream(FilePath, FileMode.Create))
            {
                FS.Write(PdfBytes, 0, PdfBytes.Length);
            }
            MessageBox.Show("Report Saved Successfully");
        }
    }
}
