using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public int id;
        public string firstName;
        public string lastName;
        public int old;
        public float salary;
        public float tax;

        public User(int id, string firstName, string lastName, int old, float salary, float tax)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.old = old;
            this.salary = salary;
            this.tax = tax;
        }

        public void oui()
        {

        }

    }
}
