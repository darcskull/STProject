using STProject.Classes;
using STProject.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace STProject
{
    public partial class FormRegister : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        const int Const_defautEvaluation = 2;
        const int Const_defautSelectItemInComboBox = -1;
        const byte Const_MaxLenghtPhoneNumber = 10;
        const byte Const_MaxLenghtFirstAndLastName = 50;
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
            student.FacultyNumber = TryToParseNumberToInt();
            student.PhoneNumber = textBoxTelNumber.Text;
            student.Password = textBoxPassword.Text;
            student.Evaluation = Const_defautEvaluation;
            student.VerifyPassword = textBoxVerifyPass.Text;
            student.Departament = comboBox1.GetItemText(this.comboBox1.SelectedItem).ToString();
            student.InsertStudent(student);
          


        }
        private int TryToParseNumberToInt()
        {
            if (!int.TryParse(textBoxNumber.Text, out int number))
            {
                throw new ArgumentException("Факултетният/Административният номер не е число!");
            }
            return number;

        }
        private void RegistrationTeacher()
        {
            Teacher teacher = new Teacher();
            teacher.Email = textBoxEmail.Text;
            teacher.FirstName = textBoxName.Text;
            teacher.LastName = textBoxSecondName.Text;
            teacher.AdminNumber = TryToParseNumberToInt();
            teacher.PhoneNumber = textBoxTelNumber.Text;
            teacher.Password = textBoxPassword.Text;
            teacher.VerifyPassword = textBoxVerifyPass.Text;
            teacher.Departament = comboBox1.GetItemText(this.comboBox1.SelectedItem).ToString();
            teacher.InsertTeacher(teacher);
        }
        private void ClearFields()
        {
              textBoxEmail.Text = string.Empty;
              textBoxName.Text = string.Empty;
              textBoxNumber.Text = string.Empty;
              textBoxPassword.Text = string.Empty;
              textBoxSecondName.Text = string.Empty;
              textBoxTelNumber.Text = string.Empty;
              textBoxVerifyPass.Text = string.Empty;
              comboBox1.SelectedIndex = Const_defautSelectItemInComboBox;
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
                MessageBox.Show("Регистрацията ви беше успешна");
                ClearFields();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не обработена грешка");
            }
        }

        

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
           
        }

        private void textBoxVerifyPass_TextChanged(object sender, EventArgs e)
        {
            textBoxVerifyPass.PasswordChar = '*';
        }

        private void textBoxTelNumber_TextChanged(object sender, EventArgs e)
        {
            textBoxTelNumber.MaxLength = Const_MaxLenghtPhoneNumber;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxName.MaxLength = Const_MaxLenghtFirstAndLastName;
        }

        private void textBoxSecondName_TextChanged(object sender, EventArgs e)
        {
            textBoxSecondName.MaxLength = Const_MaxLenghtFirstAndLastName;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }

        
}
