using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting;
            Person person = new Person("Oliver", 28);
            person.Name = "Alice";
            person.Age = 10;
            person.SayHello("Chelle", out greeting);
            Console.WriteLine("My name is {0} and my age is {1}", person.Name, person.Age);
            Console.WriteLine(greeting);
            Console.ReadLine();

            Calculator calculator = new Calculator();
            calculator.Add(10, 10);
            calculator.Add(10.5, 10.5);
            calculator.Add(10, 10, 10);
            calculator.Add(10.5, 10.5, 10.5);
            calculator.Add("10", "10");
        }
    }
}