Student student_1 = new Student("Ismoil", 25, 10);
System.Console.Write(student_1.Study());
System.Console.WriteLine("         "+student_1.GetGrade());

Student student_2 = new Student("Ghiyosov" , 23);
System.Console.WriteLine(student_2.Study());
student_2.SetGrade(12);
System.Console.WriteLine("      "+student_2.GetGrade());




public class Student 
{
    private string _fulname{get; set;}
    private int _age{get; set;}
    private int _grade{get; set;}

    public Student(string fullname, int age, int grade)
    {
        _fulname = fullname;
        _age = age;
        _grade = grade;
    }
     public Student(string fullname, int age)
    {
        _fulname = fullname;
        _age = age;
    }
     public Student()
    {
       
    }


    public string Study()
    {
        return $"{_fulname} is studying.";
    }

    public void SetGrade(int grade)
    {
        _grade = grade;
    }

    public int GetGrade()
    {
        return _grade;
    }
}