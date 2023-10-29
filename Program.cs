using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;
using المشروع;

namespace Csharp_project
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            int choice2 = 0;

            // Pre loaded empolyee details 
            List<Employees> employee = new List<Employees>();
            employee.Add(new Employees(1, "Billy", "eestreet-66", "b@gmail.com", 3917487, "teacher"));
            employee.Add(new Employees(2, "Johnathan", "eestreet-54", "j@gmail.com", 39736922, "manager"));
            employee.Add(new Employees(3, "Stacy", "eestreet-17", "s@gmail.com", 39847345, "teacher"));
            employee.Add(new Employees(4, "Jake", "eestreet-09", "jj@gmail.com", 39237355, "manager"));
            employee.Add(new Employees(5, "Clare", "eestreet-55", "c@gmail.com", 39927884, "teacher"));


            // Pre loaded students details 
            List<Students> students = new List<Students>();
            students.Add(new Students(1, "john", "street77", "a@gmail", 8383493));
            students.Add(new Students(2, "smith", "street876", "o@gmail", 1374821));
            students.Add(new Students(3, "tom", "street876", "bb@gmail", 3887437));
            students.Add(new Students(4, "lorry", "street856", "cg@gmail", 3497383));
            students.Add(new Students(5, "blare", "street876", "nk@gmail", 3048494));

            // Pre loaded courses details 
            List<Courses> CourseName = new List<Courses>();
            CourseName.Add(new Courses("1.Data Analytics", 20));
            CourseName.Add(new Courses("2.Computer Networks", 32));
            CourseName.Add(new Courses("3.Application Security", 22));
            CourseName.Add(new Courses("4.Python", 14));
            CourseName.Add(new Courses("5.Computer Security", 27));
            CourseName.Add(new Courses("6.Web development", 22));
            CourseName.Add(new Courses("7.Artificial intelligence", 36));
            CourseName.Add(new Courses("8.Algorithms", 28));
            CourseName.Add(new Courses("9.Data structure", 29));
            CourseName.Add(new Courses("10.Computer vision", 30));
            CourseName.Add(new Courses("11.Java", 20));
            CourseName.Add(new Courses("12.Business analysis and solution design", 30));
            CourseName.Add(new Courses("13.Computer systems", 32));






        Main_Menu:
            Console.WriteLine("\n.................college Managment System.................\n\n");
            Console.WriteLine("Welcome To Main Menu, Please Enter Your Choice\n");
            Console.WriteLine("Press 1 to modify empolyees");
            Console.WriteLine("Press 2 to modify students");
            Console.WriteLine("press 3 to modify courses");
            Console.WriteLine("press 4 to modify department");
            Console.WriteLine("Press 5 to exit Program");

            Console.Write("\nEnter Your Choice : ");
            string input = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out choice))
                {

                    if (choice.Equals(1))
                    {
                        Console.WriteLine("1 Press");
                        Console.Clear();
                        Console.WriteLine("\n.................college Managment System.................\n\n");
                        Console.WriteLine("Welcome To Empolyees, Please Enter Your Choice\n");
                        Console.WriteLine("Press 1 to list all employees");
                        Console.WriteLine("Press 2 to add a new employee");
                        Console.WriteLine("Press 3 to Update employee");
                        Console.WriteLine("Press 4 to Delete employee");
                        Console.WriteLine("Press 5 to return to main menu");

                        Console.Write("\nEnter Your Choice : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out choice2))
                            {
                                if (choice2.Equals(1))
                                {
                                    Console.WriteLine("\t\t\t-------Empolyees Details-------");
                                    Console.WriteLine("\n\tID \t Name \t\t Email \t\tPhone \t Address \t Role");

                                    employee.ForEach(p => p.ListAllEmpolyee());

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(2))
                                {
                                    Console.WriteLine("\n\t\t\t------- Add Empolyee -------");

                                    Employees emp = new Employees();
                                    Console.Write("Enter Empolyee ID : ");
                                    int Emp_id = Convert.ToInt32(Console.ReadLine());
                                    var empinfo = employee.Where(e => e.Empolyee_ID == Emp_id).FirstOrDefault();

                                    if (empinfo == null)
                                    {
                                        empinfo = emp;
                                        empinfo.Empolyee_ID = 0;
                                    }


                                    if (Emp_id != null)
                                    {
                                        if (empinfo.Empolyee_ID != Emp_id || empinfo.Empolyee_ID == null)
                                        {
                                            emp.Empolyee_ID = Emp_id;
                                            Console.Write("Enter Name : ");
                                            emp.Name = Console.ReadLine();
                                            Console.Write("Enter Email : ");
                                            emp.Email = Console.ReadLine();
                                            Console.Write("Enter Address : ");
                                            emp.Address = Console.ReadLine();
                                            Console.Write("Enter Phone : ");
                                            emp.Phone = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Role : ");
                                            emp.Role = Console.ReadLine();

                                            employee.Where(e => e.Empolyee_ID == emp.Empolyee_ID);
                                            employee.Where(e => e.Name == emp.Name);
                                            employee.Where(e => e.Email == emp.Email);
                                            employee.Where(e => e.Address == emp.Address);
                                            employee.Where(e => e.Phone == emp.Phone);
                                            employee.Where(e => e.Role == emp.Role);
                                            employee.Add(emp);

                                            Console.WriteLine("\n\tEmployee with id: " + Emp_id + " Added successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tEmployee " + empinfo.Empolyee_ID + " Already Exist, Choice Again Options");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Employee with id: " + Emp_id + " does not exist");
                                    }

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(3))
                                {

                                    Console.Write("Enter Empolyee_ID for Update Empolyee Profile : ");
                                    int emp_id = Convert.ToInt32(Console.ReadLine());
                                    Employees emp = new Employees();

                                    var empinfo = employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault();
                                    if (empinfo != null)
                                    {
                                        emp.Empolyee_ID = emp_id;
                                        Console.Write("Enter Name : ");
                                        emp.Name = Console.ReadLine();
                                        Console.Write("Enter Email : ");
                                        emp.Email = Console.ReadLine();
                                        Console.Write("Enter Address : ");
                                        emp.Address = Console.ReadLine();
                                        Console.Write("Enter Phone : ");
                                        emp.Phone = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Role : ");
                                        emp.Role = Console.ReadLine();



                                        employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Empolyee_ID = emp.Empolyee_ID;
                                        employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Name = emp.Name;
                                        employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Email = emp.Email;
                                        employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Address = emp.Address;
                                        employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Phone = emp.Phone;
                                        employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Role = emp.Role;

                                        Console.WriteLine("\n\tEmployee with id: " + emp_id + " updated successfully");

                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tEmployee with id: " + emp_id + " does not exist.");

                                    }


                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(4))
                                {
                                    Console.Write("\n\tEnter Empolyee_ID TO Delete Empolyee! : ");
                                    int emp_id = Convert.ToInt32(Console.ReadLine());
                                    employee.RemoveAll(e => e.Empolyee_ID == emp_id);

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(5))
                                {
                                    Console.Clear();
                                    goto Main_Menu;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Choice, Try Again");
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }


                            }
                            else
                            {
                                Console.WriteLine("Invalid Choice, Try Again");
                                Console.Write("\nEnter Your Choice : ");
                                input2 = Console.ReadLine();
                            }
                        }


                    }
                    else if (choice.Equals(2))
                    {
                        Console.WriteLine("2 Press");
                        Console.Clear();
                        Console.WriteLine("\n.................college Managment System.................\n\n");
                        Console.WriteLine("Welcome To students, Please Enter Your Choice\n");
                        Console.WriteLine("Press 1 to list all students");
                        Console.WriteLine("Press 2 to add a new students");
                        Console.WriteLine("Press 3 to Update students");
                        Console.WriteLine("Press 4 to Delete students");
                        Console.WriteLine("Press 5 to return to main menu");

                        Console.Write("\nEnter Your Choice : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out choice2))
                            {
                                if (choice2.Equals(1))
                                {
                                    Console.WriteLine("\t\t\t-------students Details-------");
                                    Console.WriteLine("\n\tID \t Name \t\t Email \t\tPhone \t Address");

                                    students.ForEach(p => p.ListAllStudents());

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(2))
                                {
                                    Console.WriteLine("\n\t\t\t------- Add Students -------");

                                    Students stu = new Students();
                                    Console.Write("Enter Students ID : ");
                                    int Stu_id = Convert.ToInt32(Console.ReadLine());
                                    var stuinfo = students.Where(s => s.Students_ID == Stu_id).FirstOrDefault();

                                    if (stuinfo == null)
                                    {
                                        stuinfo = stu;
                                        stuinfo.Students_ID = 0;
                                    }


                                    if (Stu_id != null)
                                    {
                                        if (stuinfo.Students_ID != Stu_id || stuinfo.Students_ID == null)
                                        {
                                            stu.Students_ID = Stu_id;
                                            Console.Write("Enter Name : ");
                                            stu.Name = Console.ReadLine();
                                            Console.Write("Enter Email : ");
                                            stu.Email = Console.ReadLine();
                                            Console.Write("Enter Address : ");
                                            stu.Address = Console.ReadLine();
                                            Console.Write("Enter Phone : ");
                                            stu.Phone = Convert.ToInt32(Console.ReadLine());

                                            students.Where(s => s.Students_ID == stu.Students_ID);
                                            students.Where(s => s.Name == stu.Name);
                                            students.Where(s => s.Email == stu.Email);
                                            students.Where(s => s.Address == stu.Address);
                                            students.Where(s => s.Phone == stu.Phone);
                                            students.Add(stu);

                                            Console.WriteLine("\n\tStudents with id: " + Stu_id + " Added successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tStudents " + stuinfo.Students_ID + " Already Exist, Choice Again Options");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Students with id: " + Stu_id + " does not exist");
                                    }

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();


                                }
                                else if (choice2.Equals(3))
                                {

                                    Console.Write("Enter Students_ID for Update Students Profile : ");
                                    int stu_id = Convert.ToInt32(Console.ReadLine());
                                    Students stu = new Students();

                                    var stuinfo = students.Where(s => s.Students_ID == stu_id).FirstOrDefault();
                                    if (stuinfo != null)
                                    {
                                        stu.Students_ID = stu_id;
                                        Console.Write("Enter Name : ");
                                        stu.Name = Console.ReadLine();
                                        Console.Write("Enter Email : ");
                                        stu.Email = Console.ReadLine();
                                        Console.Write("Enter Address : ");
                                        stu.Address = Console.ReadLine();
                                        Console.Write("Enter Phone : ");
                                        stu.Phone = Convert.ToInt32(Console.ReadLine());



                                        students.Where(s => s.Students_ID == stu_id).FirstOrDefault().Students_ID = stu.Students_ID;
                                        students.Where(s => s.Students_ID == stu_id).FirstOrDefault().Name = stu.Name;
                                        students.Where(s => s.Students_ID == stu_id).FirstOrDefault().Email = stu.Email;
                                        students.Where(s => s.Students_ID == stu_id).FirstOrDefault().Address = stu.Address;
                                        students.Where(s => s.Students_ID == stu_id).FirstOrDefault().Phone = stu.Phone;

                                        Console.WriteLine("\n\tStudents with id: " + stu_id + " updated successfully");


                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tStudents with id: " + stu_id + " does not exist.");

                                    }


                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(4))
                                {
                                    Console.Write("\n\tEnter Students_ID TO Delete Students! : ");
                                    int stu_id = Convert.ToInt32(Console.ReadLine());
                                    students.RemoveAll(s => s.Students_ID == stu_id);

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(5))
                                {
                                    Console.Clear();
                                    goto Main_Menu;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Choice, Try Again");
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }


                            }
                            else
                            {
                                Console.WriteLine("Invalid Choice, Try Again");
                                Console.Write("\nEnter Your Choice : ");
                                input2 = Console.ReadLine();
                            }
                        }
                    }

                    else if (choice.Equals(3))
                    {
                        Console.WriteLine("3 Press");
                        Console.Clear();
                        Console.WriteLine("\n.................college Managment System.................\n\n");
                        Console.WriteLine("Welcome To Courses, Please Enter Your Choice\n");
                        Console.WriteLine("1.List all courses");
                        Console.WriteLine("2.Add new courses");
                        Console.WriteLine("3.Delete courses");
                        Console.WriteLine("4.go back to the menu");
                        int ch = int.Parse(Console.ReadLine());
                        if (ch == 1)
                        {
                            CourseName.ForEach(p => p.ListAllCourses());

                            ;

                        }



                        else if (ch == 2)
                        {
                            Courses cou = new Courses();
                            Console.Write("Enter Course name : ");
                            string newcourse = Console.ReadLine();
                            var couinfo = CourseName.Where(c => c.CourseName == newcourse).FirstOrDefault();
                            if (couinfo == null)
                            {
                                couinfo = cou;
                                couinfo.CourseName = "0";
                            }
                            if (newcourse != null)
                            {
                                if (couinfo.CourseName != newcourse || couinfo.CourseName == null)
                                {
                                    cou.CourseName = newcourse;
                                    Console.Write("Enter duration : ");
                                    cou.CourseDuration = int.Parse(Console.ReadLine());
                                    CourseName.Where(c => c.CourseName == cou.CourseName);
                                    CourseName.Where(c => c.CourseDuration == cou.CourseDuration);
                                    CourseName.Add(cou);

                                    Console.WriteLine("\n\tStudents with id: " + newcourse + " Added successfully");
                                }
                                else
                                {
                                    Console.WriteLine("\n\tStudents " + couinfo.CourseName + " Already Exist, Choice Again Options");
                                }





                            }

                        }

                        else if (ch == 3)
                        {
                            Console.Write("\nEnter course to delete : ");
                            string newcourse = Console.ReadLine();
                            CourseName.RemoveAll(c => c.CourseName == newcourse);


                        }
                         else if (ch==4)
                                {
                                    Console.Clear();
                                    goto Main_Menu;
                                }


                        else
                        {
                            Console.WriteLine("Invalid Input! Please enter 1,2,3 or 4");
                        }

                        Console.WriteLine("press any key to go back ");
                        int ch2 = int.Parse(Console.ReadLine());

                        

                    }

                    



                    else if (choice.Equals(4))
                    {
                        Console.WriteLine("4 Press");
                        Console.Clear();
                    D :
                        Console.WriteLine("\n.................College Managment System.................\n\n");
                        Console.WriteLine("Welcome To department, Please Enter Your Choice\n");
                        Console.WriteLine("1. IS");
                        Console.WriteLine("2. CS");
                        Console.WriteLine("3. IT");
                        Console.WriteLine("Press 4 to return to main menu");
                        Console.WriteLine("Press 5 to return ");

                        Console.Write("\nEnter Your Choice : ");
                        int cho = int.Parse(Console.ReadLine());
                        Department department =null;
                        if (cho == 1)
                        {

                            department = new IS();
                            
                        }



                        else if (cho == 2)
                        {
                            department = new CS();
                            
                        }


                        else if (cho == 3)
                        {
                            department = new IT();
                           


                        }
                            
                         else if (cho==4)
                                {
                                    Console.Clear();
                                    goto Main_Menu;
                                }
                        else if (cho == 5)
                        {
                            Console.Clear();
                            goto D;
                        }


                        else
                        {
                            Console.WriteLine("Invalid Input! Please enter 1,2,3 or 4");
                        }

                      
                        department.GetDepartmentDetails();
                        Console.ReadKey();
       
                    }




                    else if (choice.Equals(5))
                    {
                        Console.WriteLine("5 Press");
                        Console.Clear();
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Choice invaild, Try Again");
                        Console.Write("\nEnter Your Choice : ");
                        input = Console.ReadLine();
                    }
                }
            }
        }
    }
}