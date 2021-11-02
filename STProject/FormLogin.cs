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
using STProject.Core;

namespace STProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            this.Hide();
            formRegister.ShowDialog();
            this.Close();
          
        }
        public Student VerifyLoginAsStudent()
        {
            var student = new Student();
            return student.ReadFromData(textBoxEmail.Text, textBoxPassword.Text);
        }
        private Teacher VerifyLoginAsTeacher()
        {
            var teacher = new Teacher();
            return teacher.ReadFromData(textBoxEmail.Text, textBoxPassword.Text);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

           
            if (radioButtonStudent.Checked && VerifyLoginAsStudent()!=null)
            {              
                FormMainPageStudent formStudent = new FormMainPageStudent();
                this.Hide();
                formStudent.ShowDialog();
                this.Close();
            }
            else if (radioButtonTeacher.Checked && VerifyLoginAsTeacher()!=null)
            {
                FormMainPageTeacher formTeacher = new FormMainPageTeacher();
                this.Hide();
                formTeacher.ShowDialog();
                this.Close();
            }
            else
            {
                lblInformation.Text = "Въвели сте грешни данни!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
