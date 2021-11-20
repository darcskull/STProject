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
        User user;
        bool checkStudent;
        public FormInformation(User u, bool isStudent)
        {
            InitializeComponent();
            user = u;
            checkStudent = isStudent;
            if (isStudent)
            {
                //TODO прочитане на всички преподаватели от базата и показването им на потребителя
            }
            else
            {
                //TODO прочитане на всички студенти от базата и показването им на потребителя
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (checkStudent)
            {
                FormMainPageStudent formStudent = new FormMainPageStudent((Student)user);
                this.Hide();
                formStudent.ShowDialog();
                this.Close();
            }
            else
            {
                FormMainPageTeacher formTeacher = new FormMainPageTeacher((Teacher)user);
                this.Hide();
                formTeacher.ShowDialog();
                this.Close();
            }
        }

        private void FormInformation_Load(object sender, EventArgs e)
        {

        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            //TODO записване на визуализираната информация във файл
        }
    }
}
