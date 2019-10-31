using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MyWindowsFormsApp.Model.Model;
namespace ObjectInitialization
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();

            employee.Id = 1;
            employee.Name = "Arafat";
            employee.Address = "Mirpur";

           // Console.WriteLine("Id: " + employee.Id+ " Name: "+ employee.Name + " Address: " +employee.Address);
            
            Employee employee2 = new Employee(2,"Fazle","Mirpur 2");
            //Console.WriteLine("Id: " + employee2.Id + " Name: " + employee2.Name + " Address: " + employee2.Address);

            Employee employee3 = new Employee(){Id = 3, Name = "Pranto", Address = "Mohammadpu"};
            //Console.WriteLine("Id: " + employee3.Id + " Name: " + employee3.Name + " Address: " + employee3.Address);

            List<Employee> employees = new List<Employee>()
                {
                    employee,
                    new Employee(){Id = 4, Name = "Rakib", Address = "Mirpur"},
                    new Employee(){Id = 5, Name = "Robin", Address = "Mirpur SP"}
                };
            //employees.Add(employee);

            foreach (Employee emp in employees)
            {
                Console.WriteLine("Id: " + emp.Id + " Name: " + emp.Name + " Address: " + emp.Address);
            }
            Console.ReadKey();
        }
    }
}
