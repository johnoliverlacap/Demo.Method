using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Method
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {

        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //this methods return value from instance method
        public string SayHello()
        {
            return "Hello, My name is " + name;
        }

        //this method returns value from parameter name
        public void SayHello(string name, out string greeting)
        {
            greeting =  "Hello, My name is " + name;
        }

        //this method return first name and lastname
        public string SayHello(string firstName, string lastName)
        {
            return "Hello, My name is " + firstName + " " + lastName;
        }

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
