using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Users
    {
        private String user_name;
        private String emp_id;
        private String role;
        private DateTime login_time;

        public Users(String user_name, String emp_id, String role, DateTime login_time)
        {
            this.User_name = user_name;
            this.Emp_id = emp_id;
            this.Role = role;
            this.Login_time = login_time;
        }

        public string User_name { get => user_name; set => user_name = value; }
        public string Emp_id { get => emp_id; set => emp_id = value; }
        public string Role { get => role; set => role = value; }
        public DateTime Login_time { get => login_time; set => login_time = value; }
    }
}
