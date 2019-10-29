using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MyWindowsFormsApp.Model;
namespace AnnonymusTypeMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Show();
            Action ShowAction = Show;
            ShowAction();

            ShowName("Yousuf");

            Action<string> ShowNameAction = ShowName;
            ShowNameAction("Hoque Sahab");

            int result = ReturnTen();
            Console.WriteLine("ReturnTen: "+ result);

            Func<int> ReturnTenFunc = ReturnTen;
            result = ReturnTenFunc();
            Console.WriteLine("ReturnTenFunc: " + result);

            result = Add(1, 3);
            Console.WriteLine("Add: " + result);

            Func<int,int, int> AddFunc = Add;
            result = AddFunc(5, 3);
            Console.WriteLine("AddFunc: " + result);

            //Func<int, int, int> AddFunc2 = (int a, int b) => { return a + b; };
            Func<int, int, int> AddFunc2 = (a, b) => { return a + b; };


            result = AddFunc2(50, 3);
            Console.WriteLine("AddFunc2: " + result);

            result = Multiply(2, 3);
            Console.WriteLine("Multiply: " + result);
            Console.ReadKey();


            

        }

        static void Show()
        {
            Console.WriteLine("Method without argument & return tyep");
        }
        static void ShowName(string name)
        {
            Console.WriteLine("Method without return tyep");
            Console.WriteLine(name);
        }

        static int ReturnTen()
        {
            return 10;
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

    }
}
