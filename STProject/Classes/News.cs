using System;


namespace STProject.Core
{
    public class News
    {
        private string name;
        private string information;
        private int id;

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

    }

}
