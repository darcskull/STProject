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
                    throw new ArgumentException("Информацията не може да бъде празна!");
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
                    throw new ArgumentException("Заглавието не може да бъде празно!");
                }
                name = value;
            }
        }
    
        public void InsertNews(News news)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into News values(N'{news.Name}',N'{news.Information}');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

}
