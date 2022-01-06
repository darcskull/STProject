using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Classes
{
    public class Data
    {
        // Променете C:\Users\Pavel\Desktop\5сем\СТ-Проект\STProject\DataBase\DBOnlineTrainingSystem.mdf с пътя на локалната ви база
        public const string connString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=D:\Technical University\Курсови работи и проекти\СТ\STProject\STProject\DataBase\DBOnlineTrainingSystem.mdf; Integrated Security=True;";
        public SqlConnection conn = new SqlConnection(connString);
        
    }
}
