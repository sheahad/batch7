using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Model.Model;
namespace AnnonymusTypeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { Id = 1, Name = "Pranto", Address = "Mohammadpu" };
            //Console.WriteLine("Id: " + employee.Id + " Name: " + employee.Name + " Address: " + employee.Address);
            
            
            List<Employee> employees = new List<Employee>()
            {
                employee,
                new Employee(){Id = 2, Name = "Rakib", Address = "Mirpur"},
                new Employee(){Id = 3, Name = "Robin", Address = "Mirpur SP"}
            };


            //====//
            var customer = new {Id = 4, Name = "Rakib", Address = "Mirpur"};

            //customer.Id = 6;
            //var a = 10;
            //a = 50;

            Console.WriteLine("Id: " + customer.Id + " Name: " + customer.Name + " Address: " + customer.Address);

            //int[] i = new[] {1, 2, 3, 4};

            var customers = new []
            {
                new { Id = 5, Name = "Rakib", Address = "Mirpur" },
                new { Id = 6, Name = "Robin", Address = "Mirpur SP" },
                new { Id = 7, Name = "Araf", Address = "Dhaka" }
            };

            Show(customers);

            Console.ReadKey();

        }

        static void Show(dynamic customers)
        {
            foreach (var cust in customers)
            {
                Console.WriteLine("Id: " + cust.Id + " Name: " + cust.Name + " Address: " + cust.Address);
            }
        }
    }
}
