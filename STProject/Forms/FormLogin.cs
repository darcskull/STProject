using STProject.Classes;
using STProject.Core;
using System;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace STProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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
            User userInformation = new User();
            if (radioButtonStudent.Checked)
            {
                lblInformation.Text = "";
                userInformation = VerifyLoginAsStudent();
                if (userInformation != null)
                {
                    FormMainPageStudent formStudent = new FormMainPageStudent((Student)userInformation);
                    this.Hide();
                    formStudent.ShowDialog();
                    this.Close();
                }
                else
                   MessageBox.Show("Не беше намерен студент, отговарящ на подадените име и парола!");
            }
            else if (radioButtonTeacher.Checked)
            {
                lblInformation.Text = "";
                userInformation = VerifyLoginAsTeacher();
                if (userInformation != null)
                {
                    FormMainPageTeacher formTeacher = new FormMainPageTeacher((Teacher)userInformation);
                    this.Hide();
                    formTeacher.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Не беше намерен преподавател, отговарящ на подадените име и парола!");
            }
            else
            {
                lblInformation.Text = "Моля изберете роля!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }
    }
}
