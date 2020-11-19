using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_Assignment
{
    class Course
    {
        private string c_Name;
        private string c_Id;
        public int c_teachingHour;
        public string _Cname
        {
            get { return c_Name; }
            set { value = c_Name; }
        }
        public string _courseId
        {
            get { return c_Id; }
            set { value = c_Id; }
        }
        public int _c_teachingHour
        {
            get { return c_teachingHour; }
            set { value = c_teachingHour; }
        }
        public void AddSection(params Section[] sections)
        {
            foreach (var s_count in sections)
            {
                sectionlist[sectionCount++] = s_count;
            }
        }

        int sectionCount;
        Section[] sectionlist;
     
        public Course(string c_Name, string c_Id, int c_teachingHour)
        {
            this.c_Name = c_Name;
            this.c_Id = c_Id;
            this.c_teachingHour = c_teachingHour;
            sectionlist = new Section[100];
        }
        public void showInfo()
        {
            Console.WriteLine("\n" + "Course Name : " +c_Name);
            Console.WriteLine("Course ID : " + c_Id);
            Console.WriteLine("Course Teaching Hour : " +c_teachingHour + "hrs");

        }
        public void ShowSection()
        {
            Console.WriteLine("Remaining Course :");
            for (int i = 0; i <sectionCount; i++)
            {
                sectionlist[i].showInfo();

            }
        }
    }
}
