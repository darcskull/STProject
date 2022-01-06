using STProject.Classes;
using STProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STProject
{
    public partial class FormActiveTest : Form
    {
        Student user = new Student();
        ReviewTest test = new ReviewTest();
        Questions[] questions = new Questions[10];
        string subject = default;
        string[] givenaswers = new string[10];
        int counter;
        private int totalSeconds = 5*60;
        private bool endTest = false;

        public FormActiveTest(Student student, Questions[] question, List<string> userAnswers = null, int userTime = 0)
        {
            InitializeComponent();
            user = student;
            questions = question;
            counter = 0;
            subject = questions[0].Subject;
            if(userTime != 0)
            {
                totalSeconds = userTime;
            }
            if(userAnswers != null)
            {
                givenaswers = userAnswers.ToArray();
            }
            setQuestion(counter);
        }

        private void FormActiveTest_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }
       
        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            setAnswer();
            Questions q = new Questions();
            q.deleteActiveTest(user.Email, subject);
            endTest = true;

            test.ReviewQuestions = questions;
            timer1.Stop();
            test.GivenAnswers = givenaswers;
            test.Email = user.Email;
            test.Subject = questions[0].Subject;
            test.Points = countPoints();
            test.Grade = gradeTest(test.Points);
            test.InsertTest(test);

            user.Evaluate(test.Grade);
            user.UpdateStudent(user.Evaluation, user.Email);

            FormTest final = new FormTest(user, test.Grade);
            this.Hide();
            final.ShowDialog();
            this.Close();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            setAnswer();
            counter--;
            if (counter < 0)
                counter = 9;

            clearButtons();
            setQuestion(counter);
            selectAnswer();

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            setAnswer();
            counter++;
            if (counter > 9)
                counter = 0;

            clearButtons();
            setQuestion(counter);
            selectAnswer();

        }

        private void setQuestion(int br)
        {
            textBoxNumberQuestion.Text = (br + 1).ToString();
            textBoxQuestion.Text = questions[br].Question;
            textBoxAnswerA.Text = questions[br].Answer1;
            textBoxAnswerB.Text = questions[br].Answer2;
            textBoxAnswerV.Text = questions[br].Answer3;
            textBoxAnswearG.Text = questions[br].Answer4;
        }

        private void setAnswer()
        {
            if (radioButtonA.Checked)
                givenaswers[counter] = questions[counter].Answer1;
            if (radioButtonB.Checked)
                givenaswers[counter] = questions[counter].Answer2;
            if (radioButtonV.Checked)
                givenaswers[counter] = questions[counter].Answer3;
            if (radioButtonG.Checked)
                givenaswers[counter] = questions[counter].Answer4;
        }

        private void clearButtons()
        {
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonG.Checked = false;
            radioButtonV.Checked = false;
        }

        private void selectAnswer()
        {
            if (givenaswers[counter] == questions[counter].Answer1)
                radioButtonA.Checked = true;
            if (givenaswers[counter] == questions[counter].Answer2)
                radioButtonB.Checked = true;
            if (givenaswers[counter] == questions[counter].Answer3)
                radioButtonV.Checked = true;
            if (givenaswers[counter] == questions[counter].Answer4)
                radioButtonG.Checked = true;
        }

        private int countPoints()
        {
            int points = 0;
            for(int i =0; i < 10; ++i)
            {
                if (givenaswers[i] == questions[i].AnswerTrue)
                    points++;
            }

            return points;
        }

        private int gradeTest(int pointss)
        {
            int[] grades = new int[] { 2, 2, 3, 4, 5, 6 };
            return grades[pointss / 2];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int leftMinute = totalSeconds / 60;
                int lestSeconds = totalSeconds - (leftMinute * 60);
                label2.Text = $"{leftMinute:d2}:{lestSeconds:d2}";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Времето ви свърши!");
                buttonEndTest_Click(sender, e);
            }
        }

        private void FormActiveTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(endTest == false)
            {
                var connection = new Data().conn;
                connection.Open();
                for (int i = 0; i < 10; ++i)
                {
                    var question = questions[i];
                    SqlCommand cmd = new SqlCommand($"INSERT INTO ActiveTest VALUES(N'{i}',N'{question.Question}',N'{question.Answer1}',N'{question.Answer2}',N'{question.Answer3}'," +
                    $"N'{question.Answer4}',N'{question.AnswerTrue}',N'{givenaswers[i]}',N'{question.Subject}' ,N'{totalSeconds}' ,N'{user.Email}');", connection);
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
