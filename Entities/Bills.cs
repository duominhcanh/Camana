using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DataLinks;
using System.Data;

namespace Entities
{
    public class Bills
    {
        private String id;
        private String emp_id;
        private DateTime date_created;
        private Dictionary<Products, int> products;
        private SqlLink sqlLink;

        public Bills(String emp_id, DateTime date_created)
        {
            sqlLink = new SqlLink();
            this.Id = genID();
            this.Emp_id = emp_id;
            this.Date_created = date_created;
            Products = new Dictionary<Products, int>();
        }

        public Bills(String BillID, String emp_id, DateTime date_created)
        {
            this.Id = BillID;
            this.Emp_id = emp_id;
            this.Date_created = date_created;
            Products = new Dictionary<Products, int>();
            sqlLink = new SqlLink();
        }

        public string Id { get => id; set => id = value; }
        public string Emp_id { get => emp_id; set => emp_id = value; }
        public DateTime Date_created { get => date_created; set => date_created = value; }
        public Dictionary<Products, int> Products { get => products; set => products = value; }

        public void add_product(Products product, int product_ammount)
        {
            if(!this.Products.ContainsKey(product))
            {
                this.Products.Add(product, product_ammount);
            }
            else
            {
                this.Products[product] += product_ammount;
            }
        }   
        
        public KeyValuePair<Products, int> find(String id)
        {
            foreach (KeyValuePair<Products, int> item in this.Products)
            {
                if (item.Key.ID == id)
                {
                    return item;
                }
            }
            return new KeyValuePair<Products, int>(null, 0);
        }

        public String genID()
        {
            List<String> ExistingBillsID = new List<string>();
            DataTable BillsIDTable = sqlLink.Select("Select BillID from Bill");
            for(int row = 0; row < BillsIDTable.Rows.Count; row++)
            {
                String currID= BillsIDTable.Rows[row][0].ToString();
                currID = currID.Substring(1);
                ExistingBillsID.Add(currID);
            }
            List<int> ExistingBillsIDInInt = new List<int>();
            foreach(String item in ExistingBillsID)
            {
                ExistingBillsIDInInt.Add(Int32.Parse(item));
            }
            ExistingBillsIDInInt.Sort();

            int newID = ExistingBillsIDInInt[ExistingBillsIDInInt.Count - 1] + 1;

            return "B" + newID.ToString();

        }

        public void saveToDb()
        {
            String nonSelectString = String.Format("insert into BILL([BillID], [EmpID], [Date]) values('{0}', '{1}', '{2}')", this.Id, this.Emp_id,
                (this.Date_created.ToShortDateString()+ " "+this.Date_created.ToShortTimeString()));
            sqlLink.NonSelect(nonSelectString);

            foreach(KeyValuePair<Products, int> item in this.Products)
            {
                String AnotherString = String.Format("insert into [BILL_DETAIL]([BillID], [ProductID], [Amount]) values('{0}', '{1}', '{2}')", this.Id, item.Key.ID,
                    item.Value);
                sqlLink.NonSelect(AnotherString);
            }

        }

        public String getEmpName()
        {
            String sqlString = "select e.EmpName from EMPLOYEE e, BILL b where e.EmpID= b.EmpID and b.BillID= '" + this.Id + "'";
            DataTable billTable = sqlLink.Select(sqlString);
            return billTable.Rows[0][0].ToString();
        }
    }
}
