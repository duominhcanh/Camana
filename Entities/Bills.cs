using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Entities
{
    public class Bills
    {
        private String id;
        private String emp_id;
        private DateTime date_created;
        private Hashtable products;

        public Bills(String id, String emp_id, DateTime date_created)
        {
            this.Id = id;
            this.Emp_id = emp_id;
            this.Date_created = date_created;
            Products = new Hashtable();
        }

        public string Id { get => id; set => id = value; }
        public string Emp_id { get => emp_id; set => emp_id = value; }
        public DateTime Date_created { get => date_created; set => date_created = value; }
        public Hashtable Products { get => products; set => products = value; }

        public void add_product(String product_id, String product_ammount)
        {
            this.Products.Add(product_id, product_ammount);
        }

    }
}
