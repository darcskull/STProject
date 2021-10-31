using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STProject
{
    public partial class FormRegister : Form
    {
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=C:\Users\Pavel\Desktop\5сем\СТ-Проект\STProject\DataBase\DBOnlineTrainingSystem.mdf; Integrated Security=True;";

        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

           
        }
       

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }

        
}
