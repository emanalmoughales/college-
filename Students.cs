using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace المشروع
{
    public class Students: Persons
    {

        public int Students_ID { get; set; }

        public Students()
        {

        }
        public Students (int students_ID, string name, string address, string email, long phone): base(name, address, email, phone)
        {
            this.Students_ID = students_ID;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
        }

        //List all students
        public void ListAllStudents()
        {
            Console.WriteLine("\n\t" + Students_ID + "\t" + Name + "\t" + Address + "\t" +  Email + "\t" + Phone  );


        }

        //add new students
        public static List<Students> Add_Students(List<Students> students, Students stu)
        {

            students.Add(stu);
            return students;

        }



    }
}
