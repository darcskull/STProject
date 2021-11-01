using STProject.Classes;
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
    public partial class FormReviewTest : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        public FormReviewTest()
        {
            InitializeComponent();
            vvalues.getSubjects(dropValyes);
            foreach (string value in dropValyes)
            {
                comboBoxSubject.Items.Add(value);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMainPageStudent formStudent = new FormMainPageStudent();
            this.Hide();
            formStudent.ShowDialog();
            this.Close();
        }

        private void FormReviewTest_Load(object sender, EventArgs e)
        {

        }
    }
}
