using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace المشروع
{
    abstract class Department
    {
        public abstract void GetDepartmentDetails();
    }

    class IS : Department
    {
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("Department: IS");
            Console.WriteLine("ccourses:");
            Console.WriteLine("Data Analytics");
            Console.WriteLine("Computer Security ");
            Console.WriteLine("C++");


           
        }
    }

    class CS : Department
    {
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("Department: CS");
            Console.WriteLine("ccourses:");
            Console.WriteLine("Data Analytics");
            Console.WriteLine("Computer Security ");
            Console.WriteLine("C++");

        }
    }

    class IT : Department
    {
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("Department: IT");
          
            Console.WriteLine("ccourses:");
            Console.WriteLine("Data Analytics");
            Console.WriteLine("Computer Security ");
            Console.WriteLine("C++");
        }
    }
}
