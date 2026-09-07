using System.Collections.Generic;
class Student
{
    public int Id;
    public string Name;
    public string Department;

    public Student(int id, string name, string department)
    {
        Id = id;
        Name = name;
        Department = department;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student(1, "Drish", "BCA"));
        students.Add(new Student(2, "Rishika", "BBA"));
        students.Add(new Student(3, "Akshatha", "BTech"));
        students.Add(new Student(4, "Thrjesh", "BCA"));
        int[,] marks =
        {
            {85, 90, 78},
            {92, 88, 95},
            {98, 95, 96},
            {88, 91, 87}
        };
        Console.WriteLine("Student Marks:\n\n");
        for (int i = 0; i < students.Count; i++)
        {
            Console.Write(students[i].Name + " : ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(marks[i, j] + " ");
            }
            Console.WriteLine();
        }
        Dictionary<string, List<Student>> departmentStudents = new Dictionary<string, List<Student>>();
        foreach (Student student in students)
        {
            if (!departmentStudents.ContainsKey(student.Department))
            {
                departmentStudents[student.Department] = new List<Student>();
            }
            departmentStudents[student.Department].Add(student);
        }
        Console.WriteLine("\nStudents by Department:\n");
        foreach(var department in departmentStudents)
        {
            Console.WriteLine(department.Key);

            foreach (Student student in department.Value)
            {
                Console.WriteLine(student.Id + " - " + student.Name);
            }
        }
    }
}
