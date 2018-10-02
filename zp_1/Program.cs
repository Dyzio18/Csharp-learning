using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zp1_lab
{


    class Program
    {

        static dynamic FindEmployee(string name, List<Employee> employees)
        {
            // employees.FindAll( );

            List<Employee> matchEmployees = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.Name == name)
                {
                    matchEmployees.Add(employee);
                }
            }
            if (matchEmployees.Count == 0) return 0;

            return matchEmployees
;
        }

        /// <summary> Write info about employees to file or console
        /// <para> Collection </para>
        /// </summary>
        static void WriteInfoAboutEmployees(List<Employee> employees)
        {
        #if RELEASE
            using (StreamWriter sw = new StreamWriter ("EmployeeData.txt")) {
                foreach (Employee employee in employees) {
                    sw.WriteLine (employee.printInfo ());
                }
            }
         #endif

        #if DEBUG
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.PrintInfo());
            }
        #endif
        }

        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Brayan", "Kowalski", new DateTime(1995, 12, 6), 3000, JobNames.JuniorDeveloper));
            employees.Add(new Employee("Janek", "Kowalski", new DateTime(1990, 6, 1), 5000, JobNames.MidDeveloper));
            employees.Add(new Employee("Stefan", "Kowalski", new DateTime(1980, 3, 17), 10000, JobNames.SeniorDeveloper ));

            // PRINT EMPLOYEES
            Program.WriteInfoAboutEmployees(employees);

            // MEAN SALARY
            MeanSalaryCalculator calculator = new MeanSalaryCalculator();
            var mean = calculator.CalculateForAgeRange(1, 60, employees);
            Console.WriteLine("Srednia pensja: " + mean + "\n");

            // FIND
            var matchEmployee = Program.FindEmployee("Janek", employees);
            Program.WriteInfoAboutEmployees(matchEmployee);

            
        }
    }
}
