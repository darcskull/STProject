using STProject.Classes;
using STProject.Interfaces;
using System;
using System.Data.SqlClient;

namespace STProject.Core
{
    public class News: Data,INews
    {
        private string name;
        private string information;

        public News(  string name, string information)
        {
            Name = name;
            Information = information;
            
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
    
        public void InsertNews(News news)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into News values('{news.Name}','{news.Information}');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

}
