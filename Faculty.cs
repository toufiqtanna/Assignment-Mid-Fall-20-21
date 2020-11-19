using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_Assignment
{
    class Faculty
    {
        private string fName;
        private string fId;
        private int fworkingHour;

        public string Name
        {
            get { return fName; }
            set { value = fName; }
        }
        public string ID
        {
            get { return fId; }
            set { value = fId; }
        }
        public int workHour
        {
            get { return fworkingHour; }
            set { value = fworkingHour; }
        }

        public Faculty (string fName,string fId,int fworkingHour)
        {
            this.fName = fName;
            this.fId = fId;
            this.fworkingHour = fworkingHour;
        }
        private int courseCount;
        private int sectionCount;
        Section[] sections;

        public void AddSection(Section s_count)
        {
            sections[sectionCount++] = s_count;

        }

        public void ShowSection()
        {
            for (int i = 0; i < sectionCount; i++)
            {
                sections[i].showInfo();

            }
        }

        public void AddTeachHour(Course crs, Section s_count)
        {
            if (fworkingHour + crs.c_teachingHour > 21)
            {
                Console.WriteLine("\n" + "Course restricted");
            }
            else
            {
                this.fworkingHour =fworkingHour + crs.c_teachingHour;
            }
        }

        public void showInfo()
        {
            Console.WriteLine("Faculty Name :" + fName);
            Console.WriteLine("Faculty ID : " + fId);
            Console.WriteLine("Weekly Teaching Hours : " + fworkingHour + " hours");
            Console.WriteLine();
            Console.WriteLine(fName+ "'s Courses :");
            FacultyCourses();
        }
        Course[] crslist;

        public void AddCourse(Course crs)
        {
            crslist[courseCount++] = crs;
        }
        public void FacultyCourses()
        {
            for (int i = 0; i < sectionCount; i++)
            {
                crslist[i].showInfo();

            }
            FacultySection();
        }

        public void FacultySection()
        {
            for (int i = 0; i < sectionCount; i++)
            {
                sections[i].showInfo();

            }
        }
    }
}
