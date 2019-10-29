using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Model.Model;

namespace ImplicitlyTypedLocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            var number2 = 20;

            number2 = 30;
            //number2 = "";

            string name = "Ali";
            var name2 = "Kamal";

            var employee  = new Employee(); 
            var employees = new List<Employee>();
        }
    }
}
