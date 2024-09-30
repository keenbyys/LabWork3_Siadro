using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LW3_Siadro
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

        public void Promote()
        {
            int increaseSalary;
            int increasePercentage = 5;

            increaseSalary = salary + (salary * increasePercentage) / 100;
            salary = increaseSalary;

            position = "Developer";
        }

        public void ToString()
        {
            Console.WriteLine("\n Name: {0}\n" +
                " Position: {1}\n" +
                " Salary: {2}", name, position, salary);
        }
    }

    class Manager : Employee
    {
        private int teamSize;

        public Manager(string name, string position, int salary, int teamSize)
            : base(name, position, salary)
        {
            this.teamSize = teamSize;
        }

        public void ConductMeeting()
        {
            Console.WriteLine(" The manager holds a meeting for a team of {0} people.", teamSize);
        }
    }

    class Developer : Employee
    {
        private string programmingLanguage;

        public Developer(string name, string position, int salary, string programmingLanguage)
            : base (name, position, salary)
        {
            this.programmingLanguage = programmingLanguage;
        }

        public override void Work()
        {
            Console.WriteLine(" {0} write code in {1}.", Name, programmingLanguage);
        }

        public void WriteCode()
        {
            Console.WriteLine(" {0} is working on programming in {1}.", Name, programmingLanguage);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string name, position;
            int salary;

            Employee employee = new Employee();
            employee.ToString();
            employee.Work();

            employee.Promote();
            employee.ToString();

            try
            {
                Console.Write(" --------------------------------\n" +
                " Name: ");
                name = Console.ReadLine();

                switch (name) 
                {
                    case "":
                        Console.WriteLine("\n Empty the data! :^)");
                        break;

                    default:
                        Console.Write("\n Position: ");
                        position = Console.ReadLine();

                        Console.Write("\n Salary: ");
                        salary = Convert.ToInt32(Console.ReadLine());

                        Employee employee1 = new Employee(name, position, salary);
                        employee1.ToString();

                        switch (position)
                        {
                            case "Manager":
                            case "manager":
                                int teamSize;
                                Console.Write("\n Team size: ");
                                teamSize = Convert.ToInt32(Console.ReadLine());

                                Manager manager = new Manager(name, position, salary, teamSize);

                                manager.Work();
                                manager.ConductMeeting();
                                break;

                            case "Developer":
                            case "developer":
                                string programmingLanguage;
                                Console.Write("\n Programming Language: ");
                                programmingLanguage = Console.ReadLine();

                                Developer developer = new Developer(name, position, salary, programmingLanguage);

                                developer.Work();
                                developer.WriteCode();
                                break;

                            case "":
                                Console.WriteLine("\n Empty the data! :^)");
                                break;

                            default:
                                Console.WriteLine("\n Enter data incorrectly! :3");
                                break;
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine(" Enter data incorrectly! :3");
            }
        }
    }
}
 