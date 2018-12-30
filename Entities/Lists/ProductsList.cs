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
           
        }

        public void saveChanges()
        {
            foreach (String proID in this.newProductID)
            {
                foreach (Products currentPro in this.productList)
                {
                    if (currentPro.ID == proID)
                    {

                        String nonSelectString =
                        "insert " + "into " + " PRODUCT " +
                        "(" + "ProductID, " + " ProductName, " + "Price " + ") " +
                        "values( " +
                        "'" + currentPro.ID + "', " +
                        "N'" + currentPro.Name + "', " +
                         + currentPro.Price  + ")";
                        sqlLink.NonSelect(nonSelectString);
                        break;
                    }
                }
            }

            foreach (String proID in this.ModifiedId)
            {
                foreach (Products currentPro in this.productList)
                {
                    if (currentPro.ID == proID)
                    {

                        String nonSelectString =
                            "update " + " PRODUCT " + "set " +
                            "ProductName= " + "N'" + currentPro.Name + "', " +
                            "Price= " +  currentPro.Price ;
                        sqlLink.NonSelect(nonSelectString);
                        break;
                    }
                }
            }

            foreach (String proID in this.deletedID)
            {
                String nonSelectString =
                "delete " + " from " + " PRODUCT " +
                "where " + " ProductID= " + "'" + proID + "'";

                sqlLink.NonSelect(nonSelectString);
            }
            this.newProductID = new HashSet<String>();
            this.deletedID = new HashSet<String>();
            this.ModifiedId = new HashSet<String>();
        }

        public List<Products> filter(String value, String field)
        {
            value = value.ToLower();
            List<Products> returnList = new List<Products>();

            foreach (Products pro in this.productList)
            {
                switch (field)
                {
                    case "ID":
                        String proID = pro.ID.ToLower();
                        if (proID.Contains(value)) returnList.Add(pro);
                        break;
                    case "Name":
                        String proName = pro.Name.ToLower();
                        if (proName.Contains(value)) returnList.Add(pro);
                        break;
                    case "Price":
                        String proPrice = pro.Price.ToString();
                        if (proPrice.Contains(value)) returnList.Add(pro);
                        break;
                }

            }

            return returnList;
        }

        /*
        public void load_resoucse()
        {
            this.ProductList = new List<Products>();
            string sqlString =
                    "select" +
                    " s.ResourcesID, s.Name" +
                    " from" +
                    " PRODUCT_DETAIL pd, STORAGE s" +
                    " where pd.ProductID='" + pro + "' and s.ResourcesID = pd.ResourcesID";
            DataTable productsTable = sqlLink.Select(sqlString);

            for (int row = 0; row < productsTable.Rows.Count; row++)
            {
                String newProID = productsTable.Rows[row][0].ToString();
                String newProName = productsTable.Rows[row][1].ToString();
                double newProPrice = Double.Parse(productsTable.Rows[row][2].ToString());


                Products newPro = new Products(newProID, newProName, newProPrice);

                this.ProductList.Add(newPro);
            }
        }
        */


    }
}
