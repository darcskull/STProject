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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked)
            {
                //TODO Проверка за валидни име и парола + падаване на данни за потребител
                FormMainPageStudent formStudent = new FormMainPageStudent();
                this.Hide();
                formStudent.ShowDialog();
                this.Close();
            }
            if (radioButtonTeacher.Checked)
            {
                //TODO Проверка за валидни име и парола + падаване на данни за потребител
                FormMainPageTeacher formTeacher = new FormMainPageTeacher();
                this.Hide();
                formTeacher.ShowDialog();
                this.Close();
            }
        }
    }
}
