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
        private HashSet<String> deletedID;
        private HashSet<String> newMaterID;
        private Dictionary<Materials, DateTime> MaterIn= new Dictionary<Materials, DateTime>();

        public MaterialsList()
        {
            this.MaterList = new List<Materials>();
            sqlLink = new SqlLink();
            this.NewMaterID = new HashSet<String>();
        }

        public List<Materials> MaterList { get => materList; set => materList = value; }
        public HashSet<string> NewMaterID { get => newMaterID; set => newMaterID = value; }

        public void add(Materials newMater)
        {
            Materials curr = this.find(newMater.Id);
            if (curr == null)
            {
                this.materList.Add(newMater);
                newMaterID.Add(newMater.Id);
                MaterIn.Add(newMater, DateTime.Now);
            }
            else
            {
                newMater.Ammount += curr.Ammount;
                MaterIn.Add(newMater, DateTime.Now);
            }


        }

        public void loadFromDb()
        {
            this.MaterList = new List<Materials>();
            String sqlString ="Select St.ResourcesID, St.Name, St.Amount from STORAGE St";

            DataTable materialsTable = sqlLink.Select(sqlString);

            for (int row = 0; row < materialsTable.Rows.Count; row++)
            {
                String newMaterID = materialsTable.Rows[row][0].ToString();
                String newMaterName = materialsTable.Rows[row][1].ToString();
                double newMaterAmmount = Double.Parse(materialsTable.Rows[row][2].ToString());
                Materials newMaters = new Materials(newMaterID, newMaterName, newMaterAmmount, "");
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

        public void saveChanges(Users us)
        {
            foreach (String materID in this.newMaterID)
            {
                foreach (Materials currentMater in this.MaterList)
                {
                    if (currentMater.Id == materID)
                    {

                        String nonSelectString =
                            String.Format("insert into STORAGE([ResourcesID], [Name], [Amount]) values('{0}', '{1}', '{2}')", 
                                currentMater.Id, currentMater.Name, currentMater.Ammount);

                        sqlLink.NonSelect(nonSelectString);
                        break;
                    }
                }
            }

            foreach (KeyValuePair<Materials, DateTime> item in this.MaterIn)
            {
                String updateString = String.Format("update STORAGE set [Name]= '{0}', [Amount]= '{1}' where [ResourcesID] = '{2}'",
                    item.Key.Name, item.Key.Ammount, item.Key.Ammount);
                sqlLink.NonSelect(updateString);
                String newString = String.Format("insert into [STORAGELN]([ProductID], [Date], [From_to], [EmpID]) values('{0}', '{1}', '{2}', '{3}')",
                    item.Key.Id, item.Value.ToShortDateString()+" "+ item.Value.ToShortTimeString(), item.Key.Supplier, us.CurEmp.Id);
                sqlLink.NonSelect(newString);
            }

        }


    }
}
