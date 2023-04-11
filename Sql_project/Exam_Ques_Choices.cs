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
    public partial class Exam_Ques_Choices : Form
    {
        public Exam_Ques_Choices()
        {
            InitializeComponent();
        }

        private void Exam_Ques_Choices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examIDComboBoxDataSet1.Exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.examIDComboBoxDataSet1.Exam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Exam_ID = int.Parse(comboBox1.Text);
            using (Examination_System_Final_ProjectEntities2 Entity = new Examination_System_Final_ProjectEntities2())
            {
                examQuesChoiceDataSet1BindingSource.DataSource = Entity.Exam_Ques_Choices(Exam_ID);
                this.reportViewer1.RefreshReport();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] PdfBytes = reportViewer1.LocalReport.Render("PDF");
                string FilePath = "D:\\ITI\\SQL\\Report6.pdf";
                using (FileStream FS = new FileStream(FilePath, FileMode.Create))
                {
                    FS.Write(PdfBytes, 0, PdfBytes.Length);
                }
                MessageBox.Show("Report Saved Successfully");
            }
            catch
            {

            }
        }
    }
}
