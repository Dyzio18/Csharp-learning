using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zp1_lab
{
    public enum JobNames
    {
        JuniorDeveloper = 1,
        MidDeveloper = 2,
        SeniorDeveloper = 3
    };

    public class Employee {
        public string Name;
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        private double salary;
        public JobNames JobPosition { get; set; }

        // https://www.p-programowanie.pl/c-sharp/wlasciwosci-akcesory-get-set/ 
        public double Salary {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public Employee () {
            this.Name = "undefined";
            this.Surname = "undefined";
        }

        public Employee(string name, string surname, DateTime birth, int salary, JobNames job)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birth;
            this.Salary = salary;
            this.JobPosition = job;
        }

        //public string printInfo () =>  $"Imie {this.Name}\nNazwisko: {this.Surname}\nData urodzenia: {this.BirthDate}\nPensja: {this.Salary}\nStanowisko: {this.JobPosition}\n";
        public string PrintInfo()
        {
            string jobPosition = Helpers.InsertSpaceBeforeUpperCase(this.JobPosition.ToString());
            return "Imie: " + this.Name + "\nNazwisko: " + this.Surname + "\nData urodzenia: " + this.BirthDate + "\nPensja: " + this.Salary + "\nStanowisko: " + jobPosition + "\n";
        }
    }
}
