using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinks;
using System.Data;

namespace Entities
{
    public class Users
    {
        private String user_name;
        private Employees curEmp;
        private String role;
        private DateTime login_time;
        private SqlLink sqlLink;

        public Users()
        {
            sqlLink = new SqlLink();
        }

        public string User_name { get => user_name; set => user_name = value; }
        public string Role { get => role; set => role = value; }
        public DateTime Login_time { get => login_time; set => login_time = value; }
        public Employees CurEmp { get => curEmp; set => curEmp = value; }

        private bool isAccountExist(String account)
        {
            String sqlString = "select '1' from ACOUNT a where a.Account = '"+ account+"'";
            DataTable accountTable = sqlLink.Select(sqlString);
            if(accountTable!= null)
            {
                if(accountTable.Rows.Count != 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private bool isPasswordTrue(String password, String username)
        {
            String sqlString = "select '1' from ACOUNT a where a.Account = '"
                +username+"' and a.Password_EMP = '"+ password + "'";
            DataTable accountTable = sqlLink.Select(sqlString);
            if (accountTable != null)
            {
                if (accountTable.Rows.Count != 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int getLoginStatus(String Username, String password)
        {
            if (!isAccountExist(Username))
            {
                return 2;
            }
            else
            {
                if(!isPasswordTrue(password, Username))
                {
                    return 1;
                }
                else
                {
                    //Success
                    this.User_name = Username;
                    this.Login_time = DateTime.Now;

                    String roleString = "select [Role_EMP] from ACOUNT where Account = '" + Username + "'";
                    DataTable roleTable = sqlLink.Select(roleString);
                    this.Role = roleTable.Rows[0][0].ToString();

                    String empString = "select e.EmpID, EmpName, Position, Phone, Sex, Birth, DateOfEmp, Address" +
                    " from EMPLOYEE e, ACOUNT a" +
                    " where e.EmpID = a.EmpID and a.Account = '" + this.User_name + "'";
                    DataTable empTable = sqlLink.Select(empString);

                    String newEmpID = empTable.Rows[0][0].ToString();
                    String newEmpName = empTable.Rows[0][1].ToString();
                    String newEmpRole = empTable.Rows[0][2].ToString();
                    String newEmpPhone = empTable.Rows[0][3].ToString();
                    String newEmpSex;
                    if (empTable.Rows[0][4].ToString().Equals("male", StringComparison.OrdinalIgnoreCase)) newEmpSex = "male";
                    else newEmpSex = "female";
                    DateTime newEmpBirth = DateTime.Parse(empTable.Rows[0][5].ToString());
                    DateTime newEmpDayIn = DateTime.Parse(empTable.Rows[0][6].ToString());
                    String newEmpAddress = empTable.Rows[0][7].ToString();

                    Employees newEmp = new Employees(newEmpID, newEmpName, newEmpAddress,
                        newEmpSex, newEmpBirth, newEmpPhone, newEmpRole, newEmpDayIn);

                    this.CurEmp = newEmp;

                    return 0;
                }
            }
        }
    }
}
