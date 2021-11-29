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
    public partial class FormMaterials : Form
    {
        User user;
        bool isStudent;
        public FormMaterials(User u, bool student)
        {
            InitializeComponent();
            user = u;
            isStudent = student;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (isStudent)
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

        private void FormMaterials_Load(object sender, EventArgs e)
        {

        }
    }
}
