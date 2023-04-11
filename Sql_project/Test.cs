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
    public partial class Test : Form
    {
        Examination_System_Final_ProjectEntities2 Entity;
        int Std_ID;
        int RemTime;
        int Exam_ID;
        int Crs_ID;
        public Test()
        {
            InitializeComponent();
            Entity = new Examination_System_Final_ProjectEntities2();
            textBox4.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
        }

        private void Test_Load(object sender, EventArgs e)
        {
            var result = Entity.Exam_Generation(Crs_Name, Std_ID, 7, 3);

            var query1 = (from q in result
                          group q by q.Question into w
                          select new
                          {
                              Question = w.Key,
                              Choice = w.Select(x => new {x.Choice_Text, x.Choice})
                          }).ToList();


            int index = 5;
            int count = 1;
            foreach (var m in query1)
            {
                Label label = this.Controls.Find("label" + index, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = m.Question;
                }
                index++;
                var Choices = m.Choice.ToList();
                if (Choices.Count == 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        RadioButton RD = this.Controls.Find("radioButton" + count, true).FirstOrDefault() as RadioButton;
                        if (RD != null)
                        {
                            RD.Text = $"{Choices[i].Choice} - {Choices[i].Choice_Text}";
                        }
                        count++;
                    }
                }
                else if (Choices.Count == 2)
                {
                    RadioButton RD1 = this.Controls.Find("radioButton" + count, true).FirstOrDefault() as RadioButton;
                    if (RD1 != null)
                    {
                        RD1.Text = $"{Choices[0].Choice} - {Choices[0].Choice_Text}";
                    }
                    count++;

                    RadioButton RD2 = this.Controls.Find("radioButton" + count, true).FirstOrDefault() as RadioButton;
                    if (RD2 != null)
                    {
                        RD2.Text = $"{Choices[1].Choice} - {Choices[1].Choice_Text}";
                    }
                    count++;

                    RadioButton RD3 = this.Controls.Find("radioButton" + count, true).FirstOrDefault() as RadioButton;
                    if (RD3 != null)
                    {
                        RD3.Visible = false;
                    }
                    count++;

                    RadioButton RD4 = this.Controls.Find("radioButton" + count, true).FirstOrDefault() as RadioButton;
                    if (RD4 != null)
                    {
                        RD4.Visible = false;
                    }
                    count++;
                }
            }
            Exam_ID = (from E in Entity.Std_Ques_Exam
                      where E.St_ID == Std_ID
                      select E.Exam_ID).FirstOrDefault();
            RemTime = 60;
            textBox3.Text = "00:60";
            timer1.Start();
        }
        public string Crs_Name
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }
        public int Get_ID
        {
            set { Std_ID = value; }
            get { return Std_ID; }
        }
        public string St_Name
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(RemTime > 0)
            {
                RemTime = RemTime - 1;
                textBox3.Text = $"00:{RemTime}";
            }
            else
            {
                timer1.Stop();
                button1_Click (sender, e );
                textBox3.Text = "00:00";
            }
        }
        public string a1
        {
            get
            {
                string ans = "";
                if (radioButton1.Checked == true)
                {
                    ans = radioButton1.Text.Split('-')[0];
                }
                else if (radioButton2.Checked == true)
                {
                    ans = radioButton2.Text.Split('-')[0];
                }
                else if (radioButton3.Checked == true)
                {
                    ans = radioButton3.Text.Split('-')[0];
                }
                else if (radioButton4.Checked == true)
                {
                    ans = radioButton4.Text.Split('-')[0];
                }
                return ans;
            }
        }
        public string a2
        {
            get
            {
                string ans = "";
                if (radioButton5.Checked == true)
                {
                    ans = radioButton5.Text.Split('-')[0];
                }
                else if (radioButton6.Checked == true)
                {
                    ans = radioButton6.Text.Split('-')[0];
                }
                else if (radioButton7.Checked == true)
                {
                    ans = radioButton7.Text.Split('-')[0];
                }
                else if (radioButton8.Checked == true)
                {
                    ans = radioButton8.Text.Split('-')[0];
                }
                return ans;
            }
        }
        public string a3
        {
            get
            {
                string ans = "";
                if (radioButton9.Checked == true)
                {
                    ans = radioButton9.Text.Split('-')[0];
                }
                else if (radioButton10.Checked == true)
                {
                    ans = radioButton10.Text.Split('-')[0];
                }
                else if (radioButton11.Checked == true)
                {
                    ans = radioButton11.Text.Split('-')[0];
                }
                else if (radioButton12.Checked == true)
                {
                    ans = radioButton12.Text.Split('-')[0];
                }
                return ans;
            }
        }
        public string a4
        {
            get
            {
                string ans = "";
                if (radioButton13.Checked == true)
                {
                    ans = radioButton13.Text.Split('-')[0];
                }
                else if (radioButton14.Checked == true)
                {
                    ans = radioButton14.Text.Split('-')[0];
                }
                else if (radioButton15.Checked == true)
                {
                    ans = radioButton15.Text.Split('-')[0];
                }
                else if (radioButton16.Checked == true)
                {
                    ans = radioButton16.Text.Split('-')[0];
                }
                return ans;
            }
        }
        public string a5
        {
            get
            {
                string ans = "";
                if (radioButton17.Checked == true)
                {
                    ans = radioButton17.Text.Split('-')[0];
                }
                else if (radioButton18.Checked == true)
                {
                    ans = radioButton18.Text.Split('-')[0];
                }
                else if (radioButton19.Checked == true)
                {
                    ans = radioButton19.Text.Split('-')[0];
                }
                else if (radioButton20.Checked == true)
                {
                    ans = radioButton20.Text.Split('-')[0];
                }
                return ans;
            }
        }
        public string a6
        {
            get
            {
                string ans = "";
                if (radioButton21.Checked == true)
                {
                    ans = radioButton21.Text.Split('-')[0];
                }
                else if (radioButton22.Checked == true)
                {
                    ans = radioButton22.Text.Split('-')[0];
                }
                else if (radioButton23.Checked == true)
                {
                    ans = radioButton23.Text.Split('-')[0];
                }
                else if (radioButton24.Checked == true)
                {
                    ans = radioButton24.Text.Split('-')[0];
                }
                return ans;
            }
        }
        public string a7
        {
            get
            {
                string ans = "";
                if (radioButton25.Checked == true)
                {
                    ans = radioButton25.Text.Split('-')[0];
                }
                else if (radioButton26.Checked == true)
                {
                    ans = radioButton26.Text.Split('-')[0];
                }
                else if (radioButton27.Checked == true)
                {
                    ans = radioButton28.Text.Split('-')[0];
                }
                else if (radioButton29.Checked == true)
                {
                    ans = radioButton30.Text.Split('-')[0];
                }
                return ans;
            }
        }
        public string a8
        {
            get
            {
                string ans = "";
                if (radioButton29.Checked == true)
                {
                    ans = radioButton29.Text.Split('-')[0];
                }
                else if (radioButton30.Checked == true)
                {
                    ans = radioButton30.Text.Split('-')[0];
                }
                else if (radioButton31.Checked == true)
                {
                    ans = radioButton31.Text.Split('-')[0];
                }
                else if (radioButton32.Checked == true)
                {
                    ans = radioButton32.Text.Split('-')[0];
                }
                return ans;
            }
        }
        public string a9
        {
            get
            {
                string ans = "";
                if (radioButton33.Checked == true)
                {
                    ans = radioButton33.Text.Split('-')[0];
                }
                else if (radioButton34.Checked == true)
                {
                    ans = radioButton34.Text.Split('-')[0];
                }
                else if (radioButton35.Checked == true)
                {
                    ans = radioButton35.Text.Split('-')[0];
                }
                else if (radioButton36.Checked == true)
                {
                    ans = radioButton36.Text.Split('-')[0];
                }
                return ans;
            }
        }
        public string a10
        {
            get
            {
                string ans = "";
                if (radioButton37.Checked == true)
                {
                    ans = radioButton37.Text.Split('-')[0];
                }
                else if (radioButton38.Checked == true)
                {
                    ans = radioButton38.Text.Split('-')[0];
                }
                else if (radioButton39.Checked == true)
                {
                    ans = radioButton39.Text.Split('-')[0];
                }
                else if (radioButton40.Checked == true)
                {
                    ans = radioButton40.Text.Split('-')[0];
                }
                return ans;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string[] Answers = { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 };
            //Entity.Student_Answer()
            if(Exam_ID != null)
            {
                try
                {
                    Entity.Student_Answer(Exam_ID, Std_ID, Answers[0], Answers[1], Answers[2], Answers[3], Answers[4], Answers[5], Answers[6], Answers[7], Answers[8], Answers[9]);
                }
                catch
                {
                    Entity.Exam_correction(Exam_ID, Std_ID);
                    var Cr_ID = (from E in Entity.Std_Course
                               where E.St_ID == Std_ID
                               select E.Course_ID).FirstOrDefault();
                    var S_C = (from S in Entity.Std_Course
                               where S.St_ID == Std_ID && S.Course_ID == Cr_ID
                               select S).FirstOrDefault();
                    MessageBox.Show($"Your Grade is {(S_C.Grade)*10} % ");
                    this.Close();
                }
            }
        }
    }
}
