
using _1_Cojuntos.Entities;

HashSet<Student> students = new HashSet<Student>();

//Console.Write("How many students for course A? ");
//int n = int.Parse(Console.ReadLine());
//for  (int i = 0; i < n; i++)
//{
//    int code = int.Parse(Console.ReadLine());
//    students.Add(new Student(code, "A"));
//}

//Console.Write("How many students for course B? ");
//n = int.Parse(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    int code = int.Parse(Console.ReadLine());
//    students.Add(new Student(code, "B"));
//}

//Console.Write("How many students for course C? ");
//n = int.Parse(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    int code = int.Parse(Console.ReadLine());
//    students.Add(new Student(code, "C"));
//}

AddStudents("A", students);
AddStudents("B", students);
AddStudents("C", students);
Console.WriteLine("Total students: " + students.Count);

static void AddStudents(string course, HashSet<Student> students)
{
    Console.Write($"How many students for course {course}? ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        int code = int.Parse(Console.ReadLine());
        students.Add(new Student(code, course));
    }
}