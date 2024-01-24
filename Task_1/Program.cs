
Teacher teacher_1 = new Teacher("Ismoil", "C#", 25);
System.Console.Write(teacher_1.Teach());
Console.WriteLine(" " + teacher_1.GetExperience());
Teacher teacher_2 = new Teacher("Ghiyosov", "C++");
System.Console.Write(teacher_2.Teach());
teacher_1.SetExperience(20);
Console.WriteLine(" "+teacher_1.GetExperience());






public class Teacher
{
    private string _Fullname { get; set; }
    private string _Subject { get; set; }
    private int _Experience { get; set; }

    public Teacher(string fullname, string subject, int experience)
    {
        _Fullname = fullname;
        _Subject = subject;
        _Experience = experience;
    }
    public Teacher(string fullname, string subject)
    {
        _Fullname = fullname;
        _Subject = subject;
    }
    public Teacher()
    {

    }
    public string Teach()
    {
        return $"{_Fullname} is teaching {_Subject}.";
    }
    public void SetExperience(int years)
    {
        _Experience = years;
    }
    public int GetExperience()
    {
        return _Experience;
    }
}