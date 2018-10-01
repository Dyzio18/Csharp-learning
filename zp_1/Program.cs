/**
@Dyzio 01.10.2018
Cwiczenia 1
Podstawy jezyka C#, tworzenie klas, skladnia jezyka, serializacja
*/

using System;
using System.Collections.Generic;

namespace zp_1 {
    class Program {
        static void Main (string[] args) {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee());
            employees.Add(new Employee());
            employees.Add(new Employee());


            foreach (Employee employee in employees){
                employee.printInfo();
            }

        }
    }
}