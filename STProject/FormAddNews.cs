using STProject.Core;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace STProject
{

    public partial class FormAddNews : Form
    {
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=C:\Users\Pavel\Desktop\5сем\СТ-Проект\STProject\DataBase\DBOnlineTrainingSystem.mdf; Integrated Security=True;";
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
        private void AddNewsInData(string news, string information)
        {
           
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"insert into News values('{news}','{information}');", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
           
        }
        private News CreateNews() => new News(textBoxName.Text,txtNews.Text);
        
        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewsInData(CreateNews().Name, CreateNews().Information);
                MessageBox.Show("Inserting News Successfully", "Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                textBoxName.Text = string.Empty;
                txtNews.Text = string.Empty;
            }
            
        }

        private void FormAddNews_Load(object sender, EventArgs e)
        {

        }
    }
}
