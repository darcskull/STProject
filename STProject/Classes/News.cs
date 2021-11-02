using STProject.Classes;
using STProject.Interfaces;
using System;
using System.Data.SqlClient;
using System.Drawing;

namespace STProject.Core
{
    public class News: Data,INews
    {
        private string name;
        private string information;
        private Image image;
        public News(  string name, string information,Image image)
        {
            Name = name;
            Information = information;
            Image = image;
        }

        public string Information
        {
            get
            {
                return information;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Информацията не може да бъде празна!");
                }
                information = value;
            }
        }
        public Image Image
        {
            get => image;
            private set => image = value;
        }

        public string Name
        {
            get
            {
                return name;
            }
           private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Заглавието не може да бъде празно!");
                }
                name = value;
            }
        }
    
        public void InsertNews(News news)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into News values(N'{news.Name}',N'{news.Information}','{news.Image}');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

}
