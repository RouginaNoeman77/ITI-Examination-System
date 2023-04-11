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
    public partial class Form1 : Form
    {
        Examination_System_Final_ProjectEntities2 Entity;
        string stdName;
        string insName;
        public Form1()
        {
            InitializeComponent();
            Entity = new Examination_System_Final_ProjectEntities2();
        }

        private void Std_Ins_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Std_Ins_ComboBox.Text != "")
            {
                if (Std_Ins_ComboBox.SelectedIndex == 0)
                {
                    label1.Text = "Enter Student Username";
                    label2.Text = "Enter student Password";
                }
                else
                {
                    label1.Text = "Enter Instructor username";
                    label2.Text = "Enter Instructor password";
                }
            }
            else
            {
                MessageBox.Show("Choose Your Position From Drop Down Menu");
            }
        }

        private void Sign_In_Btn_Click(object sender, EventArgs e)
        {
            if (Std_Ins_ComboBox.Text == "Student") //if student data is correct 
            {
                stdName = textBox1.Text;
                string stdPassword = textBox2.Text;
                var stud = (from st in Entity.Students where st.Std_UserName == stdName select st).FirstOrDefault();
                if (stud != null)
                {
                    if (stud.Std_Password == stdPassword)
                    {
                        Student_form studentForm = new Student_form();
                        studentForm.UserName = this.stdName;
                        studentForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password Is Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Student UserName Does Not Exist Or Not Correct");
                }
            }
            else if (Std_Ins_ComboBox.Text == "Instructor") //if chosen is instructor
            {
                insName = textBox1.Text;
                string insPassword = textBox2.Text;
                var instructor = (from ins in Entity.Instructors where ins.Ins_UserName == insName select ins).FirstOrDefault();
                if (instructor != null)
                {
                    if (instructor.Ins_Password == insPassword)
                    {
                        Instructor_form ins1 = new Instructor_form();
                        ins1.Ins_Name = this.insName;
                        ins1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password Is Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Instructor UserName Does Not Exist Or Not Correct");
                }
            }
        }

        private void Sign_Up_Btn_Click(object sender, EventArgs e)
        {
            if (Std_Ins_ComboBox.Text == "Student")
            {
                Create_New_Student cr_std = new Create_New_Student();
                cr_std.ShowDialog();
            }
            else
            {
                Create_New_Instructor cr_ins = new Create_New_Instructor();
                cr_ins.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
