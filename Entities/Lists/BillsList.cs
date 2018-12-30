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

        public BillsList()
        {
            this.billList = new List<Bills>();
            sqlLink = new SqlLink();

        }

        public List<Bills> BillList { get => billList; set => billList = value; }

        public void add(Bills newBill)
        {
            this.billList.Add(newBill);
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
                        if (billID.Contains(value)) returnList.Add(bill);
                        break;
                    case "Emp_id":
                        String empName = bill.Emp_id.ToLower();
                        if (empName.Contains(value)) returnList.Add(bill);
                        break;
                    case "DayCreated":
                        String date = bill.Date_created.ToShortDateString() + bill.Date_created.ToShortTimeString();
                        if (date.Contains(value)) returnList.Add(bill);
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

            foreach(Bills bll in this.billList)
            {
                String sqlStringbll = "select p.ProductID, p.ProductName, p.Price, b.Amount " +
                    " from PRODUCT p, BILL_DETAIL b " +
                    " where b.ProductID = p.ProductID and b.BillID = '" + bll.Id + "'";

                DataTable ProTable = sqlLink.Select(sqlStringbll);

                for (int row = 0; row < ProTable.Rows.Count; row++)
                {
                    String newProID = ProTable.Rows[row][0].ToString();
                    String newProName = ProTable.Rows[row][1].ToString();                    
                    Double newPrice = Double.Parse(ProTable.Rows[row][2].ToString());
                    int newProAmmount = Int32.Parse(ProTable.Rows[row][3].ToString());

                    Products newPro = new Products(newProID, newProName, newPrice);

                    bll.add_product(newPro, newProAmmount);
                }
            }
        }

    }
}
