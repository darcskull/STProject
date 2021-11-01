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

namespace STProject
{
    public partial class FormRegister : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        string phone = "-";
        int number;
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != "" && textBoxName.Text != "" && textBoxPassword.Text != "" && textBoxSecondName.Text != "" && 
                textBoxNumber.Text != "" && textBoxVerifyPass.Text != "" && comboBox1.SelectedItem != null)
            {
                if (radioButtonStudent.Checked)
                {
                    //Todo check if exist
                    Student student = new Student();
                    if (checkValidEmail(textBoxEmail.Text))
                    {
                        student.Email = textBoxEmail.Text;
                        if (textBoxPassword.Text == textBoxVerifyPass.Text && textBoxPassword.Text.Length > 5)
                        {
                            student.Password = textBoxPassword.Text;
                            if (int.TryParse(textBoxNumber.Text, out number) && number > 470000 && number < 480000)
                            {
                                student.FacultyNumber = number;
                                student.FirstName = textBoxName.Text;
                                student.LastName = textBoxSecondName.Text;
                                student.Evaluation = 1;
                                student.Departament = comboBox1.GetItemText(this.comboBox1.SelectedItem).ToString();

                                if (textBoxTelNumber.Text == "" || textBoxTelNumber.Text.Length > 10)
                                    student.PhoneNumber = phone;
                                else
                                    student.PhoneNumber = textBoxTelNumber.Text;
                                try
                                {
                                    //TODO check why can't make records in data base
                                    student.InsertStudent(student);
                                    MessageBox.Show("Регистрацията ви беше успешна");
                                }
                                catch (Exception exce)
                                {
                                    MessageBox.Show("Заявката не може да бъде изпълнена поради следната грешка: " + exce.Message);
                                }
                                finally
                                {
                                    textBoxEmail.Text = string.Empty;
                                    textBoxName.Text = string.Empty;
                                    textBoxNumber.Text = string.Empty;
                                    textBoxPassword.Text = string.Empty;
                                    textBoxSecondName.Text = string.Empty;
                                    textBoxTelNumber.Text = string.Empty;
                                    textBoxVerifyPass.Text = string.Empty;
                                    comboBox1.SelectedIndex = -1;
                                }
                            }
                            else
                                MessageBox.Show("Моля въведете валиден факултетен номер");
                        }
                        else
                            MessageBox.Show("Моля потвърдете паролата си, паролата не може да бъде по малка от 6 символа");
                    }
                    else
                        MessageBox.Show("Моля въведете валиден email адрес");
                }
               else 
               if (radioButtonTeacher.Checked)
                {
                    //Todo check if exist
                    Teacher teacher = new Teacher();
                    if (checkValidEmail(textBoxEmail.Text))
                    {
                        teacher.Email = textBoxEmail.Text;
                        if (textBoxPassword.Text == textBoxVerifyPass.Text && textBoxPassword.Text.Length > 5)
                        {
                            teacher.Password = textBoxPassword.Text;
                            if (int.TryParse(textBoxNumber.Text, out number) && number > 12340000 && number < 12350000)
                            {
                                teacher.AdminNumber = number;

                                teacher.FirstName = textBoxName.Text;
                                teacher.LastName = textBoxSecondName.Text;
                                teacher.Departament = dropValyes[comboBox1.SelectedIndex].ToLower();

                                if (textBoxTelNumber.Text == "" || textBoxTelNumber.Text.Length > 10)
                                    teacher.PhoneNumber = phone;
                                else
                                    teacher.PhoneNumber = textBoxTelNumber.Text;
                                try
                                {
                                    teacher.InsertTeacher(teacher);
                                    MessageBox.Show("Регистрацията ви беше направена успешно");
                                }
                                catch (Exception exce)
                                {
                                    MessageBox.Show("Заявката не може да бъде изпълнена поради следната грешка: " + exce.Message);
                                }
                                finally
                                {
                                    textBoxEmail.Text = string.Empty;
                                    textBoxName.Text = string.Empty;
                                    textBoxNumber.Text = string.Empty;
                                    textBoxPassword.Text = string.Empty;
                                    textBoxSecondName.Text = string.Empty;
                                    textBoxTelNumber.Text = string.Empty;
                                    textBoxVerifyPass.Text = string.Empty;
                                    comboBox1.SelectedIndex = -1;
                                }
                            }
                            else
                                MessageBox.Show("Моля въведете валиден административен номер");
                        }
                        else
                            MessageBox.Show("Моля потвърдете паролата си, паролата не може да бъде по малка от 6 символа");

                    }
                    else
                        MessageBox.Show("Моля въведете валиден email адрес");
                }
                else
                {
                    MessageBox.Show("Моля изберете роля");
                }
            }
            else
            {
                MessageBox.Show("Моля попълнете задължителните полета");
            }
           
        }

        private bool checkValidEmail(string email)
        {
            string value = "";
            for (int i=email.Length-1; i < email.Length && i>email.Length-6; --i)
            {
                if (i == email.Length - 4)
                    if (value == "gb.")
                        return true;
                if (i == email.Length - 5)
                    if (value == "moc.")
                        return true;
                value += email[i];
            }
            return false;
        }
       

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }

        
}
