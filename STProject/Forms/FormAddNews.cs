using STProject.Core;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace STProject
{

    public partial class FormAddNews : Form
    {
        Teacher user = new Teacher();
    
        public FormAddNews(Teacher u)
        {
            InitializeComponent();
            user = u;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMainPageTeacher formUser = new FormMainPageTeacher(user);
            this.Hide();
            formUser.ShowDialog();
            this.Close();
        }
 
        private News CreateNews() => new News(textBoxName.Text,txtNews.Text);
        
        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            try
            {
                CreateNews().InsertNews(CreateNews());
                MessageBox.Show("Новината беше записана успешно");
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
