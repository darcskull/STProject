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
        Questions[] questions = new Questions[10];
        string[] givenaswers = new string[10];
        int counter;
        public FormActiveTest(Student student, Questions[] question)
        {
            InitializeComponent();
            user = student;
            questions = question;
            counter = 0;
            setQuestion(0);
        }

        private void FormActiveTest_Load(object sender, EventArgs e)
        {

        }

        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            //TODO предаване на теста + запис в базата
            FormTest final = new FormTest(user);
            this.Hide();
            final.ShowDialog();
            this.Close();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //TODO записване на правилен отговор
            counter--;
            if (counter < 0)
                counter = 9;

            setQuestion(counter);

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter > 9)
                counter = 0;

            setQuestion(counter);

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
    }
}
