using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Department D = new Department("FIST");
            D.showInfo();

            Course c1 = new Course("OOP2", "C-102", 5);
            Course c2 = new Course("OOP1", "CS-101", 5);
            
            Section s1 = new Section("A");
            Section s2 = new Section("A2");
            c1.AddSection(s1, s2);
            c2.AddSection(s1, s2);

            Console.WriteLine("\n" + "*****Sections*****");

            c1.showInfo();
            c1.ShowSection();
            c2.showInfo();
            c2.ShowSection();

            Console.WriteLine("\n" + "*****Course & Faculty*****");

            Faculty f1 = new Faculty("JHON", "t-19-06",10);
            f1.AddCourse(c1);
            f1.AddSection(s1);
            f1.AddTeachHour(c1, s1);
            f1.AddTeachHour(c1, s2);
            f1.showInfo();
            Console.WriteLine();

            Faculty f2 = new Faculty("Jackie", "t-11-05",12);
            f2.showInfo();

        }
    }
}
