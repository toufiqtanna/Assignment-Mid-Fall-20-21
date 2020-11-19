using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_Assignment
{
    class Department
    {
        private string deptName;
        public string departmentName
        {
            get { return deptName; }
            set { deptName = value; }
        }
   

    public Department(string deptName)
    {
        this.deptName = deptName;
    }
    public void showInfo()
    {
        Console.WriteLine("This is Department "+deptName);
    }

    }
}
