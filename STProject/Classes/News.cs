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
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Information cannot be null or empty!");
                }
                information = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("News Name cannot be null or empty!");
                }
                name = value;
            }
        }

        public Image Image 
        { 
            get => image; 
            set => image = value;
        }

        public void InsertNews(News news)
        {
            conn.Open();
           
            SqlCommand cmd = new SqlCommand($"insert into News values('{news.Name}','{news.Information}','{news.Image}');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

}
