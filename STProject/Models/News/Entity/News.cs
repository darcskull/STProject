using STProject.Classes;
using STProject.Interfaces;
using STProject.Messages;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace STProject.Core
{
    public class News: Data,INews
    {
        private string name;
        private string information;
        private const int spaceBetweenBoxs = 110;
        private int XCordinateStart=10;
        private int sizeBoxWeight = 200;
        private int sizeBoxHeight = 100;
        private const int YcordinatePoint = 10;
        private const int textSize = 14;

        public News(  string name, string information)
        {
            Name = name;
            Information = information;
      
        }
        public News()
        {
                
        }
        
        public string Information
        {
            get
            {
                return information;
            }
             set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidInformationNews);
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTitleNews);
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

        public List<News> ReadNews()
        {
            string sql = "SELECT * FROM News";
            conn.Open();
            var cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            var news = new List<News>();
            while (rdr.Read())
            {
                var currentNews = new News(rdr.GetValue(1).ToString(),rdr.GetValue(2).ToString());
                news.Add(currentNews);
            }
            conn.Close();
            return news;
        }
        public List<TextBox> DrawNews()
        {
            var listOfNews = ReadNews();
            var listOfTextBoxs = new List<TextBox>();
            for (int i = 0; i < listOfNews.Count; i++)
            {
                var txtBox = new TextBox
                {
                    Multiline = true,
                    Size = new Size(sizeBoxWeight, sizeBoxHeight),
                    Location = new Point(YcordinatePoint, XCordinateStart),
                    Text = listOfNews[i].Name.ToString() + Environment.NewLine + listOfNews[i].Information.ToString(),
                    Enabled = false,
                };
                txtBox.Font = new Font(txtBox.Font.FontFamily, textSize);
                listOfTextBoxs.Add(txtBox);
                XCordinateStart += spaceBetweenBoxs;

            }
            return listOfTextBoxs;
        }

    }

}
