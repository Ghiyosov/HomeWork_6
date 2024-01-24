Actor actor_1 = new Actor("Robert Downey Jr", 56, "Male");
actor_1.AddMovie("Iron Man");
actor_1.AddMovie("Avengers: Endgame");
actor_1.AddMovie("Sherlock Holmes");
actor_1.Show();








public class Actor
{
    private string _fullName { get; set; }
    private int _age { get; set; }
    private string _gender { get; set; }
    private List<string> _moviesPlayed = new List<string>();

    public Actor(string fullname, int age, string gender)
    {
        _fullName = fullname;
        _age = age;
        _gender = gender;
    }

    public void AddMovie(string movieTitle)
    {
        _moviesPlayed.Add(movieTitle);
    }
    public List<string> GetMoviesPlayed()
    {
        return _moviesPlayed;
    }
    public void SetAge(int age)
    {
        _age = age;
    }
    public int GetAge()
    {
        return _age;
    }
    public void SetGender(string gender)
    {
        _gender = gender;
    }
    public string GetGender()
    {
        return _gender;
    }


    public void Show()
    {
        System.Console.WriteLine($"Actor's Name: {_fullName}");
        System.Console.WriteLine($"Age : {_age}");
        System.Console.WriteLine("Movies Played by Robert Downey Jr.:");
        for (int i = 0; i < _moviesPlayed.Count; i++)
        {
            System.Console.WriteLine($"{i}.  {_moviesPlayed[i]}");
        }
    }
}