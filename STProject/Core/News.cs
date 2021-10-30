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

        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string Information { get; set; }

        [Column]
        public string Name
        {
            //Todo:
            get 
            {
                return name;
            }
            set 
            { 
                name = value;
            }
        }

    }

}
