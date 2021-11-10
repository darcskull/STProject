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
    public partial class FormAddMaterials : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        Teacher user = new Teacher();
        public FormAddMaterials(Teacher u)
        {
            InitializeComponent();
            user = u;
            vvalues.getSubjects(dropValyes);
            foreach (string value in dropValyes)
            {
                comboBoxSubject.Items.Add(value);
            }
        }

        private void FormAddMaterials_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddMaterials_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
           FormMainPageTeacher formUser = new FormMainPageTeacher(user);
            this.Hide();
            formUser.ShowDialog();
            this.Close();
        }
    }
}
