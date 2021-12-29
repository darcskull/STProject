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
using System.Data.SqlClient;
using System.IO;

namespace STProject
{
    public partial class FormAddMaterials : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        Teacher user = new Teacher();

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=C:\Users\user\Downloads\STProject-master\STProject-master\STProject\DataBase\DBOnlineTrainingSystem.mdf; Integrated Security=True;");
        SqlCommand cmd;

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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;

                string[] f = file.Split('\\');
               
                string fn = f[(f.Length) - 1];
                string dest = @"E:\New folder\" + fn;
                string sb = comboBoxSubject.SelectedItem.ToString();
               
                File.Copy(file, dest, true);

                string q1 = $"insert into Materials values(N'{fn}',N'{sb}',N'{dest}');";
                cmd = new SqlCommand(q1, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
        }
    }
}
