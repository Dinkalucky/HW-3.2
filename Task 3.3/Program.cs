using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    public class Employee
    {
        string firstname, lastname;
        private double salary=1000;
        public double Salary
        {
            set { salary = value;}
            get { return salary;}

        }
        public double Taxes { set; get; }

        public Employee(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public void SalaryCounter(string job, int exp)
        {
            if (job == "Director")
            {
                Salary = salary*0.75;
            }
            if (job == "Manager")
            {
                Salary = salary * 0.55;
            }
            if (job == "Programmer")
            {
                Salary = salary * 0.25;
            }

            Taxes = 1000 - (Salary - (40 / exp));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname, job;
            int exp;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Як вас звуть?");
            firstname = Console.ReadLine();

            Console.WriteLine("Ваше прізвище?");
            lastname = Console.ReadLine();

            Console.WriteLine("Яка у вас посада?");
            job = Console.ReadLine();

            Console.WriteLine("Скільки років досвіду?");
            Int32.TryParse(Console.ReadLine(),out exp);

            Employee employee = new Employee(firstname, lastname);
            employee.SalaryCounter(job, exp);

            Console.WriteLine($"{firstname} {lastname} - {job} - Salary:{employee.Salary}; Taxes:{employee.Taxes}");
            Console.ReadLine();
        }
    }
}
