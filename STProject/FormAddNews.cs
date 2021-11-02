﻿using STProject.Core;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
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
 
        private News CreateNews() => new News(textBoxName.Text,txtNews.Text, pictureBox1.Image);
        
        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            try
            {
                CreateNews().InsertNews(CreateNews());
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
        string imgLocation = "";
        public byte[] AddImage()
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);
            return images;
        }
        
        private void btnImage_Click(object sender, EventArgs e)
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
