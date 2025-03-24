using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Programm
{
    static void Main(string[] args)
    {

        string salary = args[0];
        string taux = args[1];  

        double mensuelSalary = Convert.ToDouble(salary) / 12;
        double tax = double.Parse(taux);
        double netSalary = mensuelSalary * (1-tax);

        Console.WriteLine("Salaire mensuel :" + mensuelSalary);
        Console.WriteLine("Salaire net : " + netSalary);
        Console.ReadLine();
    }

}