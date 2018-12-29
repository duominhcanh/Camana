using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinks;
using System.Data;

namespace Entities.Lists
{
    public class EmployeesList
    {
        private List<Employees> empList;
        private SqlLink sqlLink;
        private HashSet<String> modifiedId;
        private HashSet<String> deletedID;
        private HashSet<String> newEmpID;

        public EmployeesList()
        {
            this.EmpList = new List<Employees>();
            this.ModifiedId = new HashSet<String>();
            sqlLink = new SqlLink();
            this.deletedID = new HashSet<String>();
            this.newEmpID = new HashSet<String>();

        }

        public HashSet<String> ModifiedId { get => modifiedId; set => modifiedId = value; }
        public List<Employees> EmpList { get => empList; set => empList = value; }


        public void add(Employees newEmployee)
        {
            this.empList.Add(newEmployee);
            newEmpID.Add(newEmployee.Id);
        }

        public void remove(String id)
        {
            foreach(Employees emp in this.EmpList.ToList())
            {
                if(emp.Id.Equals(id, StringComparison.CurrentCultureIgnoreCase))
                {
                    this.EmpList.Remove(emp);
                }
            }
            deletedID.Add(id);
            modifiedId.Remove(id);
            newEmpID.Remove(id);
        }

        public Employees find(String thisID)
        {

            foreach (Employees emp in this.EmpList.ToList())
            {
                if (emp.Id == thisID)
                {
                    return emp;
                }
            }
            return null;
        }

        public List<Employees> filter(String value, String field)
        {
            value = value.ToLower();
            List<Employees> returnList = new List<Employees>();

            foreach(Employees emp in this.empList)
            {
                switch (field)
                {
                    case "Id":
                        String empID = emp.Id.ToLower();
                        if (empID.Contains(value)) returnList.Add(emp);
                        break;
                    case "Name":
                        String empName = emp.Name.ToLower();
                        if (empName.Contains(value)) returnList.Add(emp);
                        break;
                    case "Role":
                        String empRole = emp.Role.ToLower();
                        if (empRole.Contains(value)) returnList.Add(emp);
                        break;
                    case "Phone":
                        String empPhone = emp.Phone.ToLower();
                        if (empPhone.Contains(value)) returnList.Add(emp);
                        break;
                    case "Sex":
                        String empSex = emp.Sex.ToLower();
                        if (value.StartsWith("m"))
                        {
                            if(empSex.StartsWith("m")) returnList.Add(emp);
                        }
                        else
                        {
                            if (empSex.StartsWith("f")) returnList.Add(emp);
                        }
                        break;
                    case "Birth":
                        String empBirth = emp.Birth.ToShortDateString();
                        if (empBirth.Contains(value)) returnList.Add(emp);
                        break;
                    case "DayIn":
                        String empDayIn = emp.DayIn.ToShortDateString();
                        if (empDayIn.Contains(value)) returnList.Add(emp);
                        break;
                    case "Address":
                        String empAddress = emp.Address.ToLower();
                        if (empAddress.Contains(value)) returnList.Add(emp);
                        break;
                }

            }

            return returnList;
        }

        public void loadFromDb()
        {
            this.empList = new List<Employees>();
            String sqlString =
                "select" +
                " EmpID, EmpName, Position, Phone, Sex, Birth, DateOfEmp, Address" +
                " from" +
                " EMPLOYEE";

            DataTable employeesTable = sqlLink.Select(sqlString);

            for (int row = 0; row < employeesTable.Rows.Count; row++)
            {
                String newEmpID = employeesTable.Rows[row][0].ToString();
                String newEmpName = employeesTable.Rows[row][1].ToString();
                String newEmpRole = employeesTable.Rows[row][2].ToString();
                String newEmpPhone = employeesTable.Rows[row][3].ToString();
                String newEmpSex;
                if (employeesTable.Rows[row][4].ToString().Equals("male", StringComparison.OrdinalIgnoreCase)) newEmpSex = "male";
                else newEmpSex = "female";
                DateTime newEmpBirth = DateTime.Parse(employeesTable.Rows[row][5].ToString());
                DateTime newEmpDayIn = DateTime.Parse(employeesTable.Rows[row][6].ToString());
                String newEmpAddress = employeesTable.Rows[row][7].ToString();

                Employees newEmp = new Employees(newEmpID, newEmpName, newEmpAddress,
                    newEmpSex, newEmpBirth, newEmpPhone, newEmpRole, newEmpDayIn);

                this.EmpList.Add(newEmp);
            }
        }

        public void saveChanges()
        {
            foreach (String empId in this.newEmpID)
            {
                foreach (Employees currentEmp in this.EmpList)
                {
                    if (currentEmp.Id == empId)
                    {

                        String nonSelectString =
                        "insert " + "into " + "EMPLOYEE " +
                        "(" + "EmpID, " + "EmpName, " + "Sex, " + "Birth, " +
                        "Phone, " + "Position, " + "DateOfEmp, " + "Address" + ") " +
                        "values( " +
                        "'" + currentEmp.Id + "', " +
                        "N'" + currentEmp.Name + "', " +
                        "'" + currentEmp.Sex + "', " +
                        "'" + currentEmp.Birth.ToShortDateString() + "', " +
                        "'" + currentEmp.Phone + "', " +
                        "N'" + currentEmp.Role + "', " +
                        "'" + currentEmp.DayIn.ToShortDateString() + "', " +
                        "N'" + currentEmp.Address + "')";

                        sqlLink.NonSelect(nonSelectString);
                        break;
                    }
                }
            }

            foreach (String empId in this.ModifiedId)
            {
                foreach (Employees currentEmp in this.EmpList)
                {
                    if (currentEmp.Id == empId)
                    {

                        String nonSelectString =
                            "update "     + "EMPLOYEE "   + "set "                               +
                            "EmpName= "   + "N'"          + currentEmp.Name                      +  "', "  +
                            "Sex= "       + "'"           + currentEmp.Sex                       +  "', "  +
                            "Birth= "     + "'"           + currentEmp.Birth.ToShortDateString() +  "', "  +
                            "Phone= "     + "'"           + currentEmp.Phone                     +  "', "  +
                            "Position= "  + "N'"          + currentEmp.Role                      +  "', "  +
                            "DateOfEmp= " + "'"           + currentEmp.DayIn.ToShortDateString() +  "' "   +
                            "where "      + "EmpID= "     + "'"                                  +  empId  + "'";

                        sqlLink.NonSelect(nonSelectString);
                        break;
                    }
                }
            }

            foreach (String empId in this.deletedID)
            {
                String nonSelectString =
                "delete " + "from " + "EMPLOYEE " +
                "where " + "EmpID= " + "'" + empId + "'";

                sqlLink.NonSelect(nonSelectString);
            }
            this.newEmpID = new HashSet<string>();
            this.deletedID = new HashSet<String>();
            this.ModifiedId = new HashSet<String>();
        }


    }
}
