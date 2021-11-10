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
    public partial class FormMainPageTeacher : Form
    {
        Teacher teacher = new Teacher();
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
            //TODO Падаване на данни за потребител
            FormMaterials formMaterials = new FormMaterials(teacher);
            this.Hide();
            formMaterials.ShowDialog();
            this.Close();
        }

        private void buttonAddMaterials_Click(object sender, EventArgs e)
        {
            //TODO Падаване на данни за потребител
            FormAddMaterials formMaterials = new FormAddMaterials(teacher);
            this.Hide();
            formMaterials.ShowDialog();
            this.Close();
        }

        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            //TODO Падаване на данни за потребител
            FormAddNews formNews = new FormAddNews(teacher);
            this.Hide();
            formNews.ShowDialog();
            this.Close();
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            //TODO Падаване на данни за потребител
            FormAddTest formTest = new FormAddTest(teacher);
            this.Hide();
            formTest.ShowDialog();
            this.Close();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            //TODO Падаване на данни за потребител
            FormInformation information = new FormInformation(teacher);
            this.Hide();
            information.ShowDialog();
            this.Close();
        }

        private void FormMainPageTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
