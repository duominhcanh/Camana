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
    public class Products
    {
        private String iD;
        private String name;
        private double price;
        private Dictionary<String, String> materDict;

        public Products(String id, String name, double price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            MaterDict = new Dictionary<String, String>();
        }

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public Dictionary<String, String> MaterDict { get => materDict; set => materDict = value; }

        public void getMaterFromDb()
        {
            this.MaterDict = new Dictionary<string, string>();
            String sqlString = "select s.ResourcesID, s.Name " +
                "from PRODUCT_DETAIL p, STORAGE s " +
                "where p.ProductID= '" +
                this.ID +
                "' and s.ResourcesID=p.ResourcesID ";

            SqlLink sqlLink = new SqlLink();
            DataTable materTable = sqlLink.Select(sqlString);

            for (int row = 0; row < materTable.Rows.Count; row++)
            {
                String newMaterID = materTable.Rows[row][0].ToString();
                String newMaterName = materTable.Rows[row][1].ToString();


                KeyValuePair<String, String> newMater = new KeyValuePair<string, String>(newMaterID, newMaterName);

                this.materDict.Add(newMater.Key, newMater.Value);
            }
        }
    }
}
