using STProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STProject.Core;

namespace STProject
{
    public partial class FormAddNews : Form
    {
        public FormAddNews()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMainPageTeacher formUser = new FormMainPageTeacher();
            this.Hide();
            formUser.ShowDialog();
            this.Close();
        }

        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=C:\Users\Pavel\Desktop\5сем\СТ-Проект\STProject\DataBase\DBOnlineTrainingSystem.mdf; Integrated Security=True;";
            using (var conn = new SqlConnection(connString))
            {

                conn.CreateCommand();
                string sqlString = @"SELECT n from NEWS n where ID =1";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var news = new News();
                    // news = command.ExecuteScalar() as News;

                    var result = command.ExecuteScalar() as News;
                    // Console.WriteLine(result);
                    MessageBox.Show(result.ToString() + result.ToString());

                }
            }

           /* string sql = @"SELECT N from NEWS where ID =1";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.CommandText = sql;
                SqlParameter UsernameParametar = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter PassParametar = new SqlParameter("@password", SqlDbType.VarChar);
                sqlCommand.Parameters.Add(UsernameParametar);
                sqlCommand.Parameters.Add(PassParametar);
                UsernameParametar.Value = username;
                PassParametar.Value = password;
                connection.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                if (sqlReader.HasRows)
                    success = true;
                connection.Close();
            }*/
            /*string connString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=C:\Users\Pavel\Desktop\5сем\СТ-Проект\STProject\DataBase\DBOnlineTrainingSystem.mdf; Integrated Security=True;";
            var myConnection = new SqlConnection(connString);
            SqlCommand sqlCmd = new SqlCommand();
            SqlDataReader reader;

            sqlCmd.CommandText = "SELECT * FROM Log";
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Connection = myConnection;

            myConnection.Open();

            reader = sqlCmd.ExecuteReader();

            News logs = null;

            while (reader.Read())
            {
                logs = new News();
                logs.ID = Convert.ToInt32(reader.GetValue(0));
                MessageBox.Show(logs.Information);
            }*/




        }
       

        private void FormAddNews_Load(object sender, EventArgs e)
        {

        }
    }
}
