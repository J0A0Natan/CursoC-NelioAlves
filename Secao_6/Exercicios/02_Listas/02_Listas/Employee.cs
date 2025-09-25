using System;
using System.Collections.Generic;
using System.Globalization;

namespace _02_Listas
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public void increaseSalary(double percentage)
        {
            salary += salary * percentage / 100 ;
        }

        public override string ToString()
        {
            return $"{id}, {name}, {salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
