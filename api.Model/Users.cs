using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Model
{
    public class Users
    {
        public int id { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public string insert_date { get; set; }
        

    }

    public class EmailRequest
    {
        public string email { get; set; }
    }
}
