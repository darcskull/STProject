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
    public partial class FormTest : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        Student student = new Student();
        public FormTest(Student st)
        {
            InitializeComponent();
            student = st;
            vvalues.getSubjects(dropValyes);
            foreach (string value in dropValyes)
            {
                comboBoxSubject.Items.Add(value);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Todo забраняване при стартиран тест
            FormMainPageStudent formStudent = new FormMainPageStudent(student);
            this.Hide();
            formStudent.ShowDialog();
            this.Close();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }
    }
}
