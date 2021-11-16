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
    public partial class FormReviewTest : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        Student student = new Student();
        ReviewTest reviewTest = new ReviewTest();
        int counter = 0;
        public FormReviewTest(Student st)
        {
            InitializeComponent();
            student = st;
            vvalues.getSubjects(dropValyes);
            foreach (string value in dropValyes)
            {
                comboBoxSubject.Items.Add(value);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMainPageStudent formStudent = new FormMainPageStudent(student);
            this.Hide();
            formStudent.ShowDialog();
            this.Close();
        }

        private void FormReviewTest_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            counter = 0;
            if (comboBoxSubject.SelectedIndex == -1)
                MessageBox.Show("Изберете предмет, по който желаете да прегледате своя резултат!");
            else
            {
                try
                {
                    reviewTest = reviewTest.readForReview(student.Email, comboBoxSubject.SelectedItem.ToString());
                    textBoxAnswer.Text = reviewTest.GivenAnswers[counter];
                    textBoxGivenAnswer.Text = reviewTest.ReviewQuestions[counter].AnswerTrue;
                    textBoxQuestion.Text = reviewTest.ReviewQuestions[counter].Question;
                }
                catch (Exception exc)
                {
                    textBoxAnswer.Text = "";
                    textBoxGivenAnswer.Text = "";
                    textBoxQuestion.Text = "";
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            counter--;
            if (reviewTest != null)
            {
                if (counter < 0)
                    counter = 9;

                textBoxAnswer.Text = reviewTest.GivenAnswers[counter];
                textBoxGivenAnswer.Text = reviewTest.ReviewQuestions[counter].AnswerTrue;
                textBoxQuestion.Text = reviewTest.ReviewQuestions[counter].Question;
            }
            else
                MessageBox.Show("Моля генерирайте тест за преглед");

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            counter++;
            if (reviewTest != null)
            {
                if (counter > 9)
                    counter = 0;

                textBoxAnswer.Text = reviewTest.GivenAnswers[counter];
                textBoxGivenAnswer.Text = reviewTest.ReviewQuestions[counter].AnswerTrue;
                textBoxQuestion.Text = reviewTest.ReviewQuestions[counter].Question;
            }
            else
                MessageBox.Show("Моля генерирайте тест за преглед");
        }
    }
}
