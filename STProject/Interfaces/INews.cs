using STProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STProject.Interfaces
{
    public interface INews
    {
        void InsertNews(News news);
        List<News> ReadNews();
        List<TextBox> DrawNews();
    }
}
