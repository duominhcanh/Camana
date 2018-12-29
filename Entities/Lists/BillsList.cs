using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLinks;
using System.Data;

namespace Entities.Lists
{
    public class BillsList
    {
        private List<Bills> billList;
        private SqlLink sqlLink;
        private HashSet<String> modifiedIdS;
        private HashSet<String> deletedIDS;
        private HashSet<String> newIDS;

        public BillsList()
        {
            //init
        }

    }
}
