﻿using STProject.Classes;
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
        bool haveTest = false;
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
                     List<ReviewTest> reviewList = reviewTest.readForReview(student.Email, comboBoxSubject.SelectedItem.ToString());
                    if (reviewList.Count() > 0)
                    {
                        reviewTest = reviewList.ElementAt(reviewList.Count()-1);
                        setQuestion(counter);
                        textBoxGrade.Text = reviewTest.Grade.ToString();
                        textBoxPoints.Text = reviewTest.Points.ToString();
                        checkCorrect();
                        haveTest = true;
                    }
                    else
                    {
                        resetTest();
                        MessageBox.Show("Моля направете тест по предмета, за да може да бъде прегледан!");
                    }
                }
                catch (Exception exc)
                {
                    resetTest();
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            counter--;
            if (haveTest)
            {
                if (counter < 0)
                    counter = 9;


                setQuestion(counter);
                checkCorrect();
            }
            else
                MessageBox.Show("Моля генерирайте тест за преглед");

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            counter++;
            if (haveTest)
            {
                if (counter > 9)
                    counter = 0;

                setQuestion(counter);
                checkCorrect();
            }
            else
                MessageBox.Show("Моля генерирайте тест за преглед");
        }

        private void checkCorrect()
        {
            if (textBoxAnswer.Text == textBoxGivenAnswer.Text)
                textBoxCorrect.Text = "Верен отговор";
            else
                textBoxCorrect.Text = "Грешен отговор"; 
        }

        private void setQuestion(int br)
        {
            textBoxAnswer.Text = reviewTest.ReviewQuestions[br].AnswerTrue;
            textBoxGivenAnswer.Text = reviewTest.GivenAnswers[br];
            textBoxQuestion.Text = reviewTest.ReviewQuestions[br].Question;
            textBoxQuestionNumber.Text = (br + 1).ToString();
        }

        private void resetTest()
        {
            textBoxAnswer.Text = "";
            textBoxCorrect.Text = "";
            textBoxGivenAnswer.Text = "";
            textBoxGrade.Text = "";
            textBoxPoints.Text = "";
            textBoxQuestion.Text = "";
            textBoxQuestionNumber.Text = "";
            haveTest = false;
        }
    }
}
