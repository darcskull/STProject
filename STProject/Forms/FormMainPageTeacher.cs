using STProject.Core;
using STProject.Interfaces;
using System;
using System.Windows.Forms;

namespace STProject
{
    public partial class FormMainPageTeacher : Form
    {
        Teacher teacher = new Teacher();
        bool isStudent = false;
        public FormMainPageTeacher(Teacher t)
        {
            InitializeComponent();
            teacher = t;
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form1 formlogin = new Form1();
            this.Hide();
            formlogin.ShowDialog();
            this.Close();
        }

        private void buttonMaterials_Click(object sender, EventArgs e)
        {
            FormMaterials formMaterials = new FormMaterials(teacher, isStudent);
            this.Hide();
            formMaterials.ShowDialog();
            this.Close();
        }

        private void buttonAddMaterials_Click(object sender, EventArgs e)
        {
            FormAddMaterials formMaterials = new FormAddMaterials(teacher);
            this.Hide();
            formMaterials.ShowDialog();
            this.Close();
        }

        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            FormAddNews formNews = new FormAddNews(teacher);
            this.Hide();
            formNews.ShowDialog();
            this.Close();
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            FormAddTest formTest = new FormAddTest(teacher);
            this.Hide();
            formTest.ShowDialog();
            this.Close();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            FormInformation information = new FormInformation(teacher, isStudent);
            this.Hide();
            information.ShowDialog();
            this.Close();
        }

        private void FormMainPageTeacher_Load(object sender, EventArgs e)
        {
            AddNewsInPanel();
        }
        private void AddNewsInPanel()
        {
            INews news = new News();
            foreach (var item in news.DrawNews())
            {
                panel2.Controls.Add(item);
            }
        }
    }
}
