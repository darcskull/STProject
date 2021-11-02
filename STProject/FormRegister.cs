using STProject.Classes;
using STProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;

namespace STProject
{
    public partial class FormRegister : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        const int Const_defautEvaluation = 2;
        const int Const_defautSelectItemInComboBox = -1;
        public FormRegister()
        {
            InitializeComponent();
            vvalues.getDepartments(dropValyes);
            foreach(string value in dropValyes)
            {
                comboBox1.Items.Add(value);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }

        private void RegistrationStudent()
        {
            Student student = new Student();
            student.Email = textBoxEmail.Text;
            student.FirstName = textBoxName.Text;
            student.LastName = textBoxSecondName.Text;
            student.FacultyNumber = int.Parse(textBoxNumber.Text);
            student.PhoneNumber = textBoxTelNumber.Text;
            student.Password = textBoxPassword.Text;
            student.Evaluation = Const_defautEvaluation;
            student.VerifyPassword = textBoxVerifyPass.Text;
            student.Departament = comboBox1.GetItemText(this.comboBox1.SelectedItem).ToString();
            student.InsertStudent(student);
          


        }
        private void RegistrationTeacher()
        {
            //TODO: For TEACHER AS STUDENT
            Teacher teacher = new Teacher();
            teacher.Email = textBoxEmail.Text;
            teacher.FirstName = textBoxName.Text;
            teacher.LastName = textBoxSecondName.Text;
            teacher.AdminNumber = int.Parse(textBoxNumber.Text);
            teacher.PhoneNumber = textBoxTelNumber.Text;
            teacher.Password = textBoxPassword.Text;
            teacher.Evaluation = Const_defautEvaluation;
            teacher.VerifyPassword = textBoxVerifyPass.Text;
            teacher.Departament = comboBox1.GetItemText(this.comboBox1.SelectedItem).ToString();
            teacher.InsertStudent(teacher);
          

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonStudent.Checked)
                {
                    RegistrationStudent();
                }
                else if (radioButtonTeacher.Checked)
                {
                    RegistrationTeacher();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch
            {
                MessageBox.Show("Факултетният номер трябва да бъде число", "Error");
            }
            finally
            {
                MessageBox.Show("Регистрацията ви беше успешна");
                textBoxEmail.Text = string.Empty;
                textBoxName.Text = string.Empty;
                textBoxNumber.Text = string.Empty;
                textBoxPassword.Text = string.Empty;
                textBoxSecondName.Text = string.Empty;
                textBoxTelNumber.Text = string.Empty;
                textBoxVerifyPass.Text = string.Empty;
                comboBox1.SelectedIndex = Const_defautSelectItemInComboBox;

            }

        }

      
       


        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonTeacher_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

        
}
