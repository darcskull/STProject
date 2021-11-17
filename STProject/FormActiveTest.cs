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
    public partial class FormActiveTest : Form
    {
        Student user = new Student();
        Questions[] questions = new Questions[10];
        public FormActiveTest(Student student, Questions[] question)
        {
            InitializeComponent();
            user = student;
            questions = question;
        }

        private void FormActiveTest_Load(object sender, EventArgs e)
        {

        }

        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            //TODO предаване на теста
            FormTest final = new FormTest(user);
            this.Hide();
            final.ShowDialog();
            this.Close();
        }
    }
}
