using STProject.Core;
using System;
using System.Data.SqlClient;
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
 
        private News CreateNews() => new News(textBoxName.Text,txtNews.Text,pictureBox1.Image);
        
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
        string imgLocation = "";
       
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgLocation = open.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
    }
}
