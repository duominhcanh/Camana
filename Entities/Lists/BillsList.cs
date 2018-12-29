using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinks;
using System.Data;

namespace Entities.Lists
{
    public class BillsList
    {
        private List<Bills> billList;
        private SqlLink sqlLink;
        private HashSet<String> modifiedIdS;
        private HashSet<String> deletedIDS;
        private HashSet<String> newIDS;

        public BillsList()
        {
            this.billList = new List<Bills>();
            this.modifiedIdS = new HashSet<String>();
            sqlLink = new SqlLink();
            this.deletedIDS = new HashSet<String>();
            this.newIDS= new HashSet<String>();

        }

        public HashSet<String> ModifiedId { get => modifiedIdS; set => modifiedIdS = value; }
        public List<Bills> BillList { get => billList; set => billList = value; }

        public void add(Bills newBill)
        {
            this.billList.Add(newBill);
            newIDS.Add(newBill.Id);
        }

        public void remove(String id)
        {
            foreach (Bills bill in this.billList.ToList())
            {
                if (bill.Id.Equals(id, StringComparison.CurrentCultureIgnoreCase))
                {
                    this.billList.Remove(bill);
                }
            }
            deletedIDS.Add(id);
            modifiedIdS.Remove(id);
            newIDS.Remove(id);
        }

        public Bills find(String thisID)
        {

            foreach (Bills bill in this.billList.ToList())
            {
                if (bill.Id == thisID)
                {
                    return bill;
                }
            }
            return null;
        }

        public List<Bills> filter(String value, String field)
        {
            value = value.ToLower();
            List<Bills> returnList = new List<Bills>();

            foreach (Bills bill in this.billList)
            {
                switch (field)
                {
                    case "Id":
                        String billID = bill.Id.ToLower();
                        if (bill.Id.Contains(value)) returnList.Add(bill);
                        break;
                    case "Emp_id":
                        String empName = bill.Emp_id.ToLower();
                        if (empName.Contains(value)) returnList.Add(bill);
                        break;
                }

            }
            return returnList;
        }

        public void loadFromDb()
        {
            this.billList = new List<Bills>();
            String sqlString =
                "select" +
                " BillID,EmpID,Date" +
                " from" +
                " BILL";
        
            DataTable billTable = sqlLink.Select(sqlString);

            for (int row = 0; row < billTable.Rows.Count; row++)
            {
                String newbillID = billTable.Rows[row][0].ToString();
                String newbillEmp_ID = billTable.Rows[row][1].ToString();                            
                DateTime newbillDate = DateTime.Parse(billTable.Rows[row][2].ToString());              
                Bills newBill = new Bills(newbillID, newbillEmp_ID, newbillDate);

                this.billList.Add(newBill);
            }
        }

        public void saveChanges()
        {
            foreach (String billID in this.newIDS)
            {
                foreach (Bills currentbill in this.billList)
                {
                    if (currentbill.Id == billID)
                    {

                        String nonSelectString =
                        "insert " + "into " + "BILL " +
                        "(" + "BillID, " + "EmpID, " + "Date " + ")" +
                        "values( " +
                        "'" + currentbill.Id + "', " +
                        "'" + currentbill.Emp_id + "', " +
                        "'" + currentbill.Date_created.ToShortDateString() + "') ";
                        sqlLink.NonSelect(nonSelectString);
                        break;
                    }
                }
            }

            foreach (String billId in this.ModifiedId)
            {
                foreach (Bills currentbill in this.billList)
                {
                    if (currentbill.Id == billId)
                    {

                        String nonSelectString =
                            "update " + "BILL " + "set " +
                            "EmpID= " + "N'" + currentbill.Emp_id + "', " +
                            "Date= " + "'" + currentbill.Date_created.ToShortDateString() + "'";
                        sqlLink.NonSelect(nonSelectString);
                        break;
                    }
                }
            }

            foreach (String billId in this.deletedIDS)
            {
                String nonSelectString =
                "delete " + "from " + "EMPLOYEE " +
                "where " + "EmpID= " + "'" + billId + "'";

                sqlLink.NonSelect(nonSelectString);
            }
            this.newIDS = new HashSet<string>();
            this.deletedIDS = new HashSet<String>();
            this.ModifiedId = new HashSet<String>();
        }



    }
}
