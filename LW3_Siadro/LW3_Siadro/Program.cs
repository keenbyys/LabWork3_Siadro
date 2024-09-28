using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3_Siadro
{
    internal class Program
    {
        class Employee // базовий клас
        {
            private string name;
            private string position;
            private int salary;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Position
            {
                get { return position; }
                set { position = value; }
            }

            public int Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public Employee()
            {
                name = "John Doe";
                position = "Employee";
                salary = 5000;
            }

            public Employee(string name, string position, int salary)
            {
                Name = name;
                Position = position;
                Salary = salary;
            }

            public virtual void Work()
            {
                Console.WriteLine(" {0} is doing his/her job.", name);
            }       
            
            public int Promote()
            {
                int increaseSalary;
                int increasePercentage = 5;

                return increaseSalary = (salary + salary * increasePercentage) / 100;
            }

            public void ToString()
            {
                Console.WriteLine(" Ім'я: {0}, Посада: {1}, Зарплата: {2}.", name, position, salary);
            }
        }

        class Manager : Employee
        {
            int teamSize;

            public void ConductMeeting()
            {
                Console.WriteLine(" The manager holds a meeting for a team of {0} people.", teamSize);
            }
        }

        class Developer : Employee
        {
            string programmingLanguage;

            public override void Work()
            {
                Console.WriteLine(" {0} write code in {1}.", Name, programmingLanguage);
            }

            public void WriteCode()
            {
                Console.WriteLine(" {0} is working on programming in {1}.", Name, programmingLanguage);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
 