using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Entities
{
    public class Products
    {
        private String iD;
        private String name;
        private double price;
        private Dictionary<String, String> resources;

        public Products(String id, String name, double price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Resources = new Dictionary<String, String>();
        }

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public Dictionary<String, String> Resources { get => resources; set => resources = value; }
    }
}
