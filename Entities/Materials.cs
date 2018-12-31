using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinks;
using System.Data;

namespace Entities
{
    public class Materials
    {
        private String id;
        private String name;
        private double ammount;
        private String supplier;

        public Materials(String id, String name, double ammount, string supplier)
        {
            this.Id = id;
            this.Name = name;
            this.Ammount = ammount;
            this.Supplier = supplier;
     
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Ammount { get => ammount; set => ammount = value; }
        public string Supplier { get => supplier; set => supplier = value; }

        public Dictionary<String, String> getHistory()
        {
            Dictionary<String, String> returnThing= new Dictionary<string, string>();

            DataLinks.SqlLink dl = new DataLinks.SqlLink();

            String slString = String.Format("select  s.From_to, s.Date from STORAGELN s where s.ProductID= '{0}'",
                this.Id);

            DataTable slTable = dl.Select(slString);

            for(int row=0; row<slTable.Rows.Count; row++)
            {
                returnThing.Add(slTable.Rows[row][0].ToString()+ " "+ slTable.Rows[row][1].ToString(), slTable.Rows[row][1].ToString());
            }

            return returnThing;
        }
    }
}
