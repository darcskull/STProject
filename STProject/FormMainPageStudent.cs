using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STProject.Classes;
using STProject.Core;

namespace STProject
{
    
    public partial class FormMainPageStudent : Form
    {
        Student studentt = new Student();
        bool isStudent = true;
        public FormMainPageStudent(Student student)
        {
            InitializeComponent();
            studentt = student;
            //TODO прочитането на всички новини от базата и визуализирането им
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form1 formlogin = new Form1();
            this.Hide();
            formlogin.ShowDialog();
            this.Close();
        }

        private void buttonMaterials_Click(object sender, EventArgs e)
        {
            FormMaterials formMaterials = new FormMaterials(studentt, isStudent);
            this.Hide();
            formMaterials.ShowDialog();
            this.Close();

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            FormTest formTest = new FormTest(studentt);
            this.Hide();
            formTest.ShowDialog();
            this.Close();
        }

        private void buttonReviewTest_Click(object sender, EventArgs e)
        {
            FormReviewTest formRTest = new FormReviewTest(studentt);
            this.Hide();
            formRTest.ShowDialog();
            this.Close();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            FormInformation information = new FormInformation(studentt, isStudent);
            this.Hide();
            information.ShowDialog();
            this.Close();
        }

        private void FormMainPageStudent_Load(object sender, EventArgs e)
        {
         
        }

        private void lblIInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
