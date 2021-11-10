using STProject.Classes;
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
    public partial class FormInformation : Form
    {
        //TODO проверка за преподавател
        User user;
        public FormInformation(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // TODO преверка за ролята на потребителя и връщане към FormMainTeacher
            FormMainPageStudent formStudent = new FormMainPageStudent((Student)user);
            this.Hide();
            formStudent.ShowDialog();
            this.Close();
        }

        private void FormInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
