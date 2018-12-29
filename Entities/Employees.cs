using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employees
    {
        private String id;
        private String name;
        private String address;
        private String sex;
        private DateTime birth;
        private String phone;
        private String role;
        private DateTime dayIn;

        public Employees(String Id, String Name, String Address, String Sex, DateTime Birth,
            String Phone, String Role, DateTime DayIn)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Sex = Sex;
            this.Birth = Birth;
            this.Phone = Phone;
            this.Role = Role;
            this.DayIn = DayIn;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Role { get => role; set => role = value; }
        public DateTime DayIn { get => dayIn; set => dayIn = value; }

        override
        public String ToString()
        {
            return (this.Id+ " - "+ this.Name + " - "+ this.Address + " - "+
                this.Sex + " - " +this.Birth.ToShortDateString() + " - " +
                this.Phone + " - " +this.Role + " - " +
                this.DayIn.ToShortDateString());
        }
    }
}
