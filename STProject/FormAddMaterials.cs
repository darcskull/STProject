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
        public FormAddMaterials()
        {
            InitializeComponent();
        }

        private void FormAddMaterials_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddMaterials_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
           FormMainPageTeacher formUser = new FormMainPageTeacher();
            this.Hide();
            formUser.ShowDialog();
            this.Close();
        }
    }
}
