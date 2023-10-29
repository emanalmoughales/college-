using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace المشروع
{
     public class Courses 
    { 
        public string CourseName{ get; set; } 
        public int CourseDuration { get; set; } 
 
        public Courses(string CousreName, int CourseDuration) 
        { 
            this.CourseName = CousreName; 
            this.CourseDuration = CourseDuration; 
        } 
        public Courses() 
        { 
        } 
 
        public void ListAllCourses() 
        { 
            Console.WriteLine("\n\t" + CourseName + "\t" + CourseDuration + "weeks"); 
 
        } 
 
        
        //add new Course 
        public static List<Courses> AddCourse(List<Courses> CourseName, Courses courses) 
        { 
 
            CourseName.Add(courses); 
            return CourseName; 
 
       } 
          
 
 
        internal static void Add(string inputcourse) 
        { 
            throw new NotImplementedException(); 
        } 
    } 
}
