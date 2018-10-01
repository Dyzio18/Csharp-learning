/**
@Dyzio 01.10.2018
Cwiczenia 1
Podstawy jezyka C#, tworzenie klas, skladnia jezyka, serializacja
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace zp_1 {
    class Program {

        
        /// <summary> Write info about employees to file or console
        /// <para> Collection </para>
        /// </summary>
        static void WriteInfoAboutEmployees (List<Employee> employees) {

#if RELEASE
            using (StreamWriter sw = new StreamWriter ("EmployeeData.txt")) {
                foreach (Employee employee in employees) {
                    sw.WriteLine (employee.printInfo ());
                }
            }
#endif

#if DEBUG
            foreach (Employee employee in employees) {
                Console.WriteLine (employee.printInfo ());
            }
#endif

        }

        static void Main (string[] args) {

            List<Employee> employees = new List<Employee> ();
            employees.Add (new Employee ("Brayan", "Kowalski", new DateTime (1995, 12, 6), 3000, 1));
            employees.Add (new Employee ("Janek", "Kowalski", new DateTime (1990, 6, 1), 5000, 2));
            employees.Add (new Employee ("Stefan", "Kowalski", new DateTime (1980, 3, 17), 10000, 3));

            Program.WriteInfoAboutEmployees (employees);
        }
    }
}