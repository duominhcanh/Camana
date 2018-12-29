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
        private Dictionary<Products, int> products;

        public Bills(String id, String emp_id, DateTime date_created)
        {
            this.Id = id;
            this.Emp_id = emp_id;
            this.Date_created = date_created;
            Products = new Dictionary<Products, int>();
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
    }
}
