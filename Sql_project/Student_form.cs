using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_project
{
    public partial class Student_form : Form
    {
        string un;
        public string UserName 
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value;}
        }
        Examination_System_Final_ProjectEntities2 Entity;
        public Student_form()
        {
            InitializeComponent();
            Entity = new Examination_System_Final_ProjectEntities2();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check student credentials
            //call generate exam sp "Malak"
            Test ex1 = new Test();
            ex1.Crs_Name = comboBox1.Text;
            ex1.Get_ID = int.Parse(textBox2.Text);
            ex1.St_Name = textBox3.Text;
            ex1.ShowDialog();
        }

        private void Student_form_Load(object sender, EventArgs e)
        {
            un = textBox1.Text;
            var result = (from S in Entity.Students
                          where S.Std_UserName == un
                          select S).FirstOrDefault();
            if (result != null)
            {
                textBox3.Text = $"{result.F_Name} {result.L_Name}";
                textBox2.Text = $"{result.St_ID}";
            }
            int Std_ID = int.Parse(textBox2.Text);
            var Crs = (from E in Entity.Std_Course
                            where E.St_ID == Std_ID
                            select E);
            foreach (var C in Crs )
            {
                comboBox1.Items.Add(C.Course.Course_Name);
            }

            //Filling reports combo box
            Std_Reports_Combo_Box.Items.Add("Grades");
            Std_Reports_Combo_Box.Items.Add("Course Topics");
        }

        private void Std_Reports_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Std_Reports_Combo_Box.Text == "Grades")
            {
                label5.Text = "This Report Will Show Your Grades In Each Course";
            }
            else if (Std_Reports_Combo_Box.Text == "Course Topics")
            {
                label5.Text = "This Report Will Show You The Topics Of The Choosen Course";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Std_Reports_Combo_Box.Text == "Grades")
            {
                Std_Grade_Report SGR = new Std_Grade_Report();
                SGR.Student_ID = this.textBox2.Text;
                SGR.ShowDialog();
            }
            else if (Std_Reports_Combo_Box.Text == "Course Topics")
            {
                Crs_Topic CT = new Crs_Topic();
                CT.Crs_Name = this.comboBox1.Text;
                CT.ShowDialog();
            }
        }
    }
}
