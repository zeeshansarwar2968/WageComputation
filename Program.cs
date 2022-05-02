// See https://aka.ms/new-console-template for more information
using System;

namespace WageComputation // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation");
            WageComputation objEmp = new WageComputation();
            objEmp.CheckPresence();    
        }
    }
}
