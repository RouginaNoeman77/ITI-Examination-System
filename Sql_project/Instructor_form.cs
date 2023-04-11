using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sql_project
{
    public partial class Instructor_form : Form
    {
        Examination_System_Final_ProjectEntities2 Entity;
        int Inst_ID;
        public Instructor_form()
        {
            InitializeComponent();
            groupBox1.Visible= false;
            Entity = new Examination_System_Final_ProjectEntities2();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //select question type
        {
            if (comboBox2.Text == "T/F")
            {
                textBox5.Text = "True";
                textBox6.Text = "False";
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled= false;
                textBox8.Enabled = false;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("A");
                comboBox3.Items.Add("B");
            }
            else
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("A");
                comboBox3.Items.Add("B");
                comboBox3.Items.Add("C");
                comboBox3.Items.Add("D");
                textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) //shows or hide add question group box
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert question into database
            Question Qs = new Question();
            ICollection<Choice> choices = new List<Choice>();
            if(textBox3.Text != "" && textBox4.Text !="" && textBox5.Text!="" && textBox6.Text != "")
            {
                int Q_Id = int.Parse(textBox10.Text);
                string Q_Text = textBox3.Text;
                string Q_Type = comboBox2.SelectedItem.ToString();
                string Model_Answer = comboBox3.SelectedItem.ToString();
                int Q_Point = int.Parse(textBox4.Text);
                int Crs_ID = int.Parse(comboBox1.SelectedItem.ToString());
                Choice Ans1 = new Choice();
                Ans1.Quest_ID = Qs.Question_ID;
                Ans1.Choice_Text = textBox5.Text;
                Ans1.Choice1 = textBox11.Text;
                Choice Ans2 = new Choice();
                Ans2.Quest_ID = Qs.Question_ID;
                Ans2.Choice_Text = textBox6.Text;
                Ans2.Choice1 = textBox12.Text;
                choices.Add(Ans1);
                choices.Add(Ans2);
                if(comboBox2.SelectedText == "Choice")
                {
                    Choice Ans3 = new Choice();
                    Ans3.Quest_ID = Qs.Question_ID;
                    Ans3.Choice_Text = textBox7.Text;
                    Ans3.Choice1 = textBox13.Text;

                    Choice Ans4 = new Choice();
                    Ans3.Quest_ID = Qs.Question_ID;
                    Ans3.Choice_Text = textBox8.Text;
                    Ans3.Choice1 = textBox14.Text;

                    choices.Add(Ans3);
                    choices.Add(Ans4);
                }
                var CheckQuesID = (from q in Entity.Questions where q.Question_ID == Q_Id select q).FirstOrDefault();
                if (CheckQuesID == null)
                {
                    Qs.Question_ID = Q_Id;
                    Qs.Text = Q_Text;
                    Qs.Type = Q_Type;
                    Qs.Model_Answer = Model_Answer;
                    Qs.Point = Q_Point;
                    Qs.Course_ID = int.Parse(comboBox1.SelectedItem.ToString());
                    Qs.Choices = choices;
                    Entity.Questions.Add(Qs);
                    Entity.SaveChanges();
                    MessageBox.Show("Question Added Succesfuly!");
                    textBox3.Text = textBox10.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox4.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = "";
                }
                else
                {
                    MessageBox.Show("Question Id Already Exists");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Full Infromation");
            }
        }
        public string Ins_Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void Instructor_form_Load(object sender, EventArgs e)
        {
            string Ins_Un = textBox1.Text;
            var Instructor = (from ins in Entity.Instructors where ins.Ins_UserName == Ins_Un select ins).FirstOrDefault();
            if (Instructor != null)
            {
                Inst_ID = Instructor.Instructor_ID;
                textBox2.Text = Instructor.Instructor_ID.ToString();
            }

            //Query To Add This INstructors Departments in Enabled TextBox
            var Departments = (from Dept in Entity.Departments
                               join Ins in Entity.Instructors on Dept.Dept_ID equals Ins.Dept_ID
                               where Ins.Instructor_ID == Inst_ID
                               select Dept);
            foreach (var Dept in Departments)
            {
                textBox9.Text = (Dept.Dept_Name);
            }
            //Filling Course ComboBox Related To Instructor
            var Courses = from crs in Entity.Inst_Course where crs.Ins_ID == Inst_ID select crs;
            foreach (var Course in Courses)
            {
                comboBox1.Items.Add(Course.Course_ID);
            }
            //Reports Combobox
            comboBox4.Items.Add("Students Per Department");
            comboBox4.Items.Add("Student's Grades");
            comboBox4.Items.Add("Courses For Each Instructor");
            comboBox4.Items.Add("Reviewing Specific Exam");
            comboBox4.Items.Add("Reviewing Student Answer in Exam");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Students Per Department")
            {
                Ins_Std_Dept ISD = new Ins_Std_Dept();
                ISD.ShowDialog();
            }
            else if (comboBox4.Text == "Student's Grades")
            {
                Ins_Std_Grade ISG = new Ins_Std_Grade();
                ISG.ShowDialog();
            }
            else if (comboBox4.Text == "Courses For Each Instructor")
            {
                Ins_crs IC = new Ins_crs();
                IC.ShowDialog();
            }
            else if (comboBox4.Text == "Reviewing Specific Exam")
            {
                Exam_Ques_Choices EQC = new Exam_Ques_Choices();
                EQC.ShowDialog();
            }
            else if (comboBox4.Text == "Reviewing Student Answer in Exam")
            {
                Quest_Std_Answ QSA = new Quest_Std_Answ();
                QSA.ShowDialog();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox4.Text == "Students Per Department")
            {
                textBox15.Text = "Report that returns the students information according to Department No parameter.";
            }
            else if (comboBox4.Text == "Student's Grades")
            {
                textBox15.Text = "Report that takes the student ID and returns the grades of the student in all courses.";
            }
            else if (comboBox4.Text == "Courses For Each Instructor")
            {
                textBox15.Text = "Report that takes the instructor ID and returns the name of the courses that he teaches and the number of student per course.";
            }
            else if (comboBox4.Text == "Reviewing Specific Exam")
            {
                textBox15.Text = "Report that takes exam number and returns the Questions in it and chocies";
            }
            else if (comboBox4.Text == "Reviewing Student Answer in Exam")
            {
                textBox15.Text = "Report that takes exam number and the student ID then returns the Questions in this exam with the student answers.";
            }
        }
    }
}
