using STProject.Classes;
using STProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        string[] givenaswers = new string[10];
        int counter;
        private int totalSeconds = 5*60;
       
        public FormActiveTest(Student student, Questions[] question)
        {
            InitializeComponent();
            user = student;
            questions = question;
            counter = 0;
            setQuestion(counter);
        }

        private void FormActiveTest_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;


        }

        //TODO активиране на бутона след изтичане на времето
       
        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            setAnswer();
            test.ReviewQuestions = questions;
            test.GivenAnswers = givenaswers;
            test.Email = user.Email;
            test.Subject = questions[0].Subject;
            test.Points = countPoints();
            test.Grade = gradeTest(test.Points);

            
            //TODO запис в базата на теста + проверка за съществуването му и ъпдеит ако съществува
            // test.InsertTest(test); - fix querry 

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
    }
}
