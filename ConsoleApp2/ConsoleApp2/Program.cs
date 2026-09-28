using System;

class Employee
{
    public int Id;
    public string Name;
    public double BasicSalary;
    public string CompanyName = "ADvera";

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        BasicSalary = salary;
    }
    public double CalculateSalary()
    {
        double DA = BasicSalary * 0.10;
        double HRA = BasicSalary * 0.20;
        double PF = BasicSalary * 0.12;

        double Gross = BasicSalary + DA + HRA;
        double Net = Gross - PF;

        Console.WriteLine("\nCompany: " + CompanyName);
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Salary: " + BasicSalary);
        Console.WriteLine("DA: " + DA);
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("PF: " + PF);
        Console.WriteLine("Gross Salary: " + Gross);
        Console.WriteLine("Net Salary: " + Net);

        return Net;
    }

    public double CalculateSalary(double Bonus)
    {
        double DA = BasicSalary * 0.10;
        double HRA = BasicSalary * 0.20;
        double PF = BasicSalary * 0.12;

        double Gross = BasicSalary + DA + HRA + Bonus;
        double Net = Gross - PF;

        Console.WriteLine("\n=====Salary With Bonus=====");
        Console.WriteLine("\nCompany: " + CompanyName);
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Salary: " + BasicSalary);
        Console.WriteLine("DA: " + DA);
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("PF: " + PF);
        Console.WriteLine("Bonus: " + Bonus);
        Console.WriteLine("Gross Salary: " + Gross);
        Console.WriteLine("Net Salary: " + Net);

        return Net;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Basic Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Employee emp = new Employee(id, name, salary);
        Console.WriteLine("\nSalary Without Bonus");
        emp.CalculateSalary();
        Console.Write("\nEnter Bonus: "); 
        double bonus = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nSalary With Bonus");
        emp.CalculateSalary(bonus);
        Console.ReadLine();
    }
}
