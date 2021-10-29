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
        public FormInformation()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // TODO преверка за ролята на потребителя и връщане към FormMainTeacher
            FormMainPageStudent formStudent = new FormMainPageStudent();
            this.Hide();
            formStudent.ShowDialog();
            this.Close();
        }
    }
}
