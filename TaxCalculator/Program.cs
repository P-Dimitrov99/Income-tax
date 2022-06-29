using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //we prompt the user to give us the salary which they need tax calculated on
            Console.WriteLine("Input salary:");
            //we save the salary into a variable
            double salary = double.Parse(Console.ReadLine());
            //there is no taxation to amounts <= 1000
            if (salary <= 1000)
            {
                Console.WriteLine($"The net salary is: {salary}");
            }
            //every other amount requires the method we created to be called
            else
            {
                calculateTax(salary);
            }
            //we create a method which calculates both point 2 and 3 from the task
            double calculateTax(double sal)
            {
                sal = salary - 1000;
                sal -= sal * 0.1;
                //we need one last if statement to check if the amount is lower than 3k
                if (sal < 3000)
                {
                    sal -= sal * 0.15;
                }
                sal += 1000;
                Console.WriteLine($"The net salary is: {sal}");
                return 1;
            }
            //to continue adding more taxes to the system
            //we need to add an "else if" + the calculaations for the case between the if and else
        }
    }
}
