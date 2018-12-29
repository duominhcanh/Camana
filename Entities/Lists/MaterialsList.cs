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
                "select" +
                " [ResourcesID], [Name], [Amount]" +
                " from" +
                " [STORAGE]";

            DataTable materialsTable = sqlLink.Select(sqlString);

            for (int row = 0; row < materialsTable.Rows.Count; row++)
            {
                String newMaterID = materialsTable.Rows[row][0].ToString();
                String newMaterName = materialsTable.Rows[row][1].ToString();
                double newMaterAmmount = Double.Parse(materialsTable.Rows[row][2].ToString());
                Materials newMaters = new Materials(newMaterID, newMaterName, newMaterAmmount);
                this.materList.Add(newMaters);
            }
        }

    }
}
