using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_Assignment
{
    class Section
    {
        private string s_Name;
        public string SectionName
        {
            get;set;
        }
        public Section(string s_Name)
        {
            this.s_Name=s_Name;
        }
        public void showInfo()
        {
            Console.WriteLine("Section: " + s_Name);
        }
    }
}
