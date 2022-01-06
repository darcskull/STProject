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
    public partial class FormTest : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        Student student = new Student();
        Questions qq = new Questions();
        public FormTest(Student st, int grade)
        {
            InitializeComponent();
            student = st;
            vvalues.getSubjects(dropValyes);
            foreach (string value in dropValyes)
            {
                comboBoxSubject.Items.Add(value);
            }

            textBoxGrade.Text = student.Evaluation.ToString();

            if (grade != 0)
                MessageBox.Show("Оценката на теста е " + grade);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMainPageStudent formStudent = new FormMainPageStudent(student);
            this.Hide();
            formStudent.ShowDialog();
            this.Close();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxSubject.SelectedIndex != -1)
            {
                var activeTestQuestions = qq.checkActiveTest();
                if (activeTestQuestions.Item1.Count != 0 && activeTestQuestions.Item1.ElementAt(0).Subject == comboBoxSubject.SelectedItem.ToString())
                {
                    qq.deleteActiveTest();
                    FormActiveTest active = new FormActiveTest(student, ConvertListToArray(activeTestQuestions.Item1), activeTestQuestions.Item3, activeTestQuestions.Item2);
                    this.Hide();
                    active.ShowDialog();
                    this.Close();
                }
                else
                {
                    List<Questions> questionss = qq.readQuestions(comboBoxSubject.SelectedItem.ToString());
                    if (questionss.Count() >= 10)
                    {
                        Questions[] testQq = GenerateQuestions(questionss);
                        FormActiveTest active = new FormActiveTest(student, testQq);
                        this.Hide();
                        active.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Няма достатъчен брой въпроси, от които да бъде генериран уникален тест. Моля свържете се с вашия ръководител");
                }
                
            }
            else
                MessageBox.Show("Моля изберете предмет на теста");
        }

        private Questions[] GenerateQuestions(List<Questions> questions)
        {
            Questions[] testQuestions = new Questions[10];
            Random random = new Random();
            int number = random.Next(0, questions.Count()-10);
            for(int i=0; i < 10; ++i)
            {
                testQuestions[i] = questions.ElementAt(number+i);
            }

            return testQuestions;
        }

        private Questions[] ConvertListToArray(List<Questions> questions)
        {
            Questions[] activeTestQuestions = new Questions[10];
            for (int i = 0; i < 10; ++i)
            {
                activeTestQuestions[i] = questions.ElementAt(i);
            }

            return activeTestQuestions;
        }
    }
}
