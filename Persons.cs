using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace المشروع
{ //abstract class
     public abstract class Persons
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

         public Persons()
        {

        }
        public Persons(string name, string address, string email, long phone)
        {
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
        }
    
    }
}