﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
