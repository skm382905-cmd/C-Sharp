using System;

interface ILogin
{
    void Login();
}
interface IProfile
{
    void ShowProfile();
}
class User
{
    protected string name;
    protected int id;
    public User(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
    public void ShowUser()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
    }
}

class Student : User, ILogin, IProfile
{
    string course;
    public Student(string name, int id, string course) : base(name, id)
    {
        this.course = course;
    }
    public void Login()
    {
        Console.WriteLine("Student logged in");
    }

    public void ShowProfile()
    {
        Console.WriteLine("Student Profile");
        ShowUser();
        Console.WriteLine("Course: " + course);
    }
}
class Faculty : User, ILogin, IProfile
{
    string subject;

    public Faculty(string name, int id, string subject) : base(name, id)
    {
        this.subject = subject;
    }

    public void Login()
    {
        Console.WriteLine("Faculty logged in");
    }

    public void ShowProfile()
    {
        Console.WriteLine("Faculty Profile");
        ShowUser();
        Console.WriteLine("Subject: " + subject);
    }
}
class Admin : Faculty
{
    string role;

    public Admin(string name, int id, string subject, string role)
        : base(name, id, subject)
    {
        this.role = role;
    }

    public void ShowAdmin()
    {
        Console.WriteLine("Admin Profile");
        ShowUser();
        Console.WriteLine("Role: " + role);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Rahul", 101, "Computer Science");
        Faculty f = new Faculty("Anita", 201, "C# Programming");
        Admin a = new Admin("Ramesh", 301, "Management", "System Admin");
        s.Login();
        s.ShowProfile();
        Console.WriteLine();
        f.Login();
        f.ShowProfile();
        Console.WriteLine();
        a.Login();
        a.ShowAdmin();
    }
}
