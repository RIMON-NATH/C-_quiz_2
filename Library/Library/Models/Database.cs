using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Database
    {
        public Books Books { get; set; }
        public Database()
        {
            string connetionString = @"Server=DESKTOP-TQA9GGD\SQLEXPRESS;Database=BMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connetionString);
            Books = new Books(conn);
        }
    
     }
}
