using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zp1_lab
{
    class MeanSalaryCalculator
    {

        public double CalculateForAgeRange(int low, int high, List<Employee> employees)
        {
            double salarySum = 0;
            int fitEmployeeCounter = 0;

            foreach (Employee employee in employees)
            {
                if(this.employeesWhichFitToRange(low,high,employee)){
                    fitEmployeeCounter++;
                    salarySum += employee.Salary;
                }
            }

            if (fitEmployeeCounter == 0)
            {
                Console.WriteLine("Brak pracownikow w tym zakresie\n");
                return 0;
            }
            return (salarySum / fitEmployeeCounter);
        }

        private Boolean employeesWhichFitToRange(int low, int high, Employee employee)
        {
            TimeSpan employeeAge = DateTime.Now - employee.BirthDate;
            int age = (int)(employeeAge.Days / 365);
            if(age >= low && age <= high){
                return true;
            }
            return false;
            
        }
    }
}
