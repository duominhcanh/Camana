using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinks;
using System.Data;

namespace Entities.Lists
{
    public class ProductsList
    {
        private List<Products> productList;
        private SqlLink sqlLink;
        private HashSet<String> modifiedId;
        private HashSet<String> deletedID;
        private HashSet<String> newProductID;

        public ProductsList()
        {
            this.ProductList = new List<Products>();
            this.ModifiedId = new HashSet<String>();
            sqlLink = new SqlLink();
            this.deletedID = new HashSet<String>();
            this.newProductID = new HashSet<String>();
        }

        public List<Products> ProductList { get => productList; set => productList = value; }
        public HashSet<string> ModifiedId { get => modifiedId; set => modifiedId = value; }

        public void add(Products newEmployee)
        {
            this.ProductList.Add(newEmployee);
            newProductID.Add(newEmployee.ID);
        }

        public void remove(String id)
        {
            foreach (Products pro in this.ProductList.ToList())
            {
                if (pro.ID.Equals(id, StringComparison.CurrentCultureIgnoreCase))
                {
                    this.ProductList.Remove(pro);
                }
            }
            deletedID.Add(id);
            modifiedId.Remove(id);
            newProductID.Remove(id);
        }

        public Products find(String thisID)
        {

            foreach (Products pro in this.ProductList.ToList())
            {
                if (pro.ID == thisID)
                {
                    return pro;
                }
            }
            return null;
        }

        public void loadFromDb()
        {
            this.ProductList = new List<Products>();
            String sqlString =
                "select" +
                " ProductID, ProductName, Price" +
                " from" +
                " PRODUCT";

            DataTable productsTable = sqlLink.Select(sqlString);

            for (int row = 0; row < productsTable.Rows.Count; row++)
            {
                String newProID = productsTable.Rows[row][0].ToString();
                String newProName = productsTable.Rows[row][1].ToString();
                double newProPrice = Double.Parse(productsTable.Rows[row][2].ToString());


                Products newPro = new Products(newProID, newProName, newProPrice);

                this.ProductList.Add(newPro);
            }
            foreach(Products pro in this.ProductList)
            {
                sqlString =
                    "select" +
                    " s.ResourcesID, s.Name" +
                    " from" +
                    " PRODUCT_DETAIL pd, STORAGE s"+
                    " where pd.ProductID='"+ pro.ID +"' and s.ResourcesID= pd.ResourcesID";
                DataTable resourcesTable = sqlLink.Select(sqlString);
                for (int row = 0; row < productsTable.Rows.Count; row++)
                {
                    String newResID = productsTable.Rows[row][0].ToString();
                    String newResName = productsTable.Rows[row][1].ToString();

                    pro.Resources.Add(newResID, newResName);
                }

            }
        }

    }
}
