using System;

public class Employee
{
    public string Name;
    public string Surname { get; set; }
    private DateTime BirthDate { get; set; }
    private string JobPosition { get; set; }
    private double Salary { get; set; }


    public Employee()
    {
        Name = "Jan";
        Surname = "Kowalski";
    }

    public void printInfo(){
        Console.WriteLine($"Imie {this.Name}\nNazwisko: {this.Surname}\nData urodzenia: {this.BirthDate}\nPensja: {this.Salary}\nStanowisko: {this.JobPosition}\n");
    }
}
