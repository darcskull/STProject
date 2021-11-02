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
        private Form1 formLogin;
        public FormMainPageStudent()
        {
            InitializeComponent();
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
            //TODO Падаване на данни за потребител
            FormMaterials formMaterials = new FormMaterials();
            this.Hide();
            formMaterials.ShowDialog();
            this.Close();

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //TODO Падаване на данни за потребител
            FormTest formTest = new FormTest();
            this.Hide();
            formTest.ShowDialog();
            this.Close();
        }

        private void buttonReviewTest_Click(object sender, EventArgs e)
        {
            //TODO Падаване на данни за потребител
            FormReviewTest formRTest = new FormReviewTest();
            this.Hide();
            formRTest.ShowDialog();
            this.Close();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            //TODO Падаване на данни за потребител
            FormInformation information = new FormInformation();
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
