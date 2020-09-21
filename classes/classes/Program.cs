using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer p = new Customer("Yamini", "Chakka");
            p.printFullName();
        }
    }
    class Customer
    {
        string _firstname;
        string _lastname;
        public Customer(string Firstname, string Lastname)
        {
            this._firstname = Firstname;
            this._lastname = Lastname;
        }
        public void printFullName()
        {
            Console.WriteLine("Full Name = {0} ", this._firstname + " " + this._lastname);
        }
    }
}