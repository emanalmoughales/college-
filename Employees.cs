using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace المشروع
{
    public class Employees: Persons
    {

        public int Empolyee_ID { get; set; }
        public string Role { get; set; }

        public Employees()
        {

        }
        public Employees(int empolyee_ID, string name, string address, string email, long phone, string role): base(name, address, email, phone)
        {
            this.Empolyee_ID = empolyee_ID;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
            this.Role = role;
        }

        //List all empolyee
        public void ListAllEmpolyee()
        {
            Console.WriteLine("\n\t" + Empolyee_ID + "\t" + Name + "\t" + Address + "\t" + Email + "\t" + Phone+"\t" + Role);


        }

        //add new Empolyee
        public static List<Employees> Add_Employee(List<Employees> employee, Employees emp)
        {

            employee.Add(emp);
            return employee;

        }

    }
}
