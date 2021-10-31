using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace STProject.Core
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("News")]
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

        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        [Column]
        public int ID 
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        [Column]
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

        [Column]
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
