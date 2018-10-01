using System;

public class Employee {
    public string Name;
    public string Surname { get; set; }
    private DateTime BirthDate { get; set; }
    private double Salary { get; set; }
    private int JobPosition { get; set; }

    enum Jobs : int { JuniorDeveloper,  MidDeveloper, SeniorDeveloper};

    public Employee () {
        this.Name = "undefined";
        this.Surname = "undefined";
    }
    public Employee (string name, string surname, DateTime birth, int salary, int job) {
        this.Name = name;
        this.Surname = surname;
        this.BirthDate = birth;
        this.Salary = salary;
        this.JobPosition = job;
    }

    public string printInfo () => $"Imie {this.Name}\nNazwisko: {this.Surname}\nData urodzenia: {this.BirthDate}\nPensja: {this.Salary}\nStanowisko: {this.JobPosition}\n";

}