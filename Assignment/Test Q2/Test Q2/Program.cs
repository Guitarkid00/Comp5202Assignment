using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Q2
{
    class Employee
    {
        public string name { get; set; }
        public double salary { get; set; }
        public double taxrate { get; set; }

        public Employee(string _name, int _salary, int _taxrate) //Constructor
        {
            name = _name;
            salary = _salary;
            taxrate = _taxrate;
        }

        public static double CalcNet(double salary, double taxrate) //Method for calculating net salary
        {
            double CalcNet = salary - (salary * (taxrate / 100));
            return CalcNet;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rotorua Holiday Park Payroll System");
            Employee E1 = new Employee("Unknown", 0, 0); //Creating a default record
            Console.WriteLine("Employee record created");
            Console.Write("Please enter your name: ");
            E1.name = Console.ReadLine(); //Setting E1 name
            Console.Write("Please enter your gross salary: ");
            E1.salary = Convert.ToInt32(Console.ReadLine()); //Setting E1 salary
            Console.Write("Please enter your tax rate (%): ");
            E1.taxrate = Convert.ToInt32(Console.ReadLine()); //Seeting E1 tac rate
            Console.WriteLine();
            Console.WriteLine($"Your name: {E1.name}");  //Displaying the information stored in the E1 object
            Console.WriteLine($"Your salary: {E1.salary}");
            Console.WriteLine($"Your tax rate (%): {E1.taxrate}");
            double NetSalary = Employee.CalcNet(E1.salary, E1.taxrate); //Created a variable in the main method that stores the result of the ClacNet method
            Console.WriteLine($"Your net salary: {NetSalary}");
            Console.ReadLine();
        }
    }
}
