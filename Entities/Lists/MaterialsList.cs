using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinks;
using System.Data;

namespace Entities.Lists
{
    public class MaterialsList
    {
        private List<Materials> materList;
        private SqlLink sqlLink;
        private HashSet<String> modifiedId;
        private HashSet<String> deletedID;
        private HashSet<String> newMaterID;

        public MaterialsList()
        {
            this.MaterList = new List<Materials>();
            this.modifiedId = new HashSet<String>();
            sqlLink = new SqlLink();
            this.deletedID = new HashSet<String>();
            this.NewMaterID = new HashSet<String>();
        }

        public List<Materials> MaterList { get => materList; set => materList = value; }
        public HashSet<string> NewMaterID { get => newMaterID; set => newMaterID = value; }

        public void add(Materials newMater)
        {
            this.materList.Add(newMater);
            newMaterID.Add(newMater.Id);
        }

        public void loadFromDb()
        {
            this.MaterList = new List<Materials>();
            String sqlString =
                " select " +
                " distinct(s.ResourcesID), [Name], [Amount], From_to " +
                " from" +
                " STORAGE s, STORAGELN s1" +
                " where " +
                " s.ResourcesID = s.ResourcesID" ;

            DataTable materialsTable = sqlLink.Select(sqlString);

            for (int row = 0; row < materialsTable.Rows.Count; row++)
            {
                String newMaterID = materialsTable.Rows[row][0].ToString();
                String newMaterName = materialsTable.Rows[row][1].ToString();
                double newMaterAmmount = Double.Parse(materialsTable.Rows[row][2].ToString());
                String newMaterFromto= materialsTable.Rows[row][3].ToString();
                Materials newMaters = new Materials(newMaterID, newMaterName, newMaterAmmount, newMaterFromto);
                this.materList.Add(newMaters);
            }
        }

        public Materials find(String thisID)
        {

            foreach (Materials mat in this.materList.ToList())
            {
                if (mat.Id == thisID)
                {
                    return mat;
                }
            }
            return null;
        }

        public List<Materials> filter(String value, String field)
        {
            value = value.ToLower();
            List<Materials> returnList = new List<Materials>();

            foreach (Materials mater in this.materList)
            {
                switch (field)
                {
                    case "ID":
                        String materID = mater.Id.ToLower();
                        if (materID.Contains(value)) returnList.Add(mater);
                        break;
                    case "Name":
                        String materName = mater.Name.ToLower();
                        if (materName.Contains(value)) returnList.Add(mater);
                        break;
                    case "Ammount":
                        String materAmmount = mater.Ammount.ToString();
                        if (materAmmount.Contains(value)) returnList.Add(mater);
                        break;
                    case "Supplier":
                        String materSupp = mater.Supplier.ToLower();
                        if (materSupp.Contains(value)) returnList.Add(mater);
                        break;
                }

            }

            return returnList;
        }

    }
}
