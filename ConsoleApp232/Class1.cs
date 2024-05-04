﻿namespace Console123;

public class User
{

    private List<int> score = new List<int>();

    public User(string name, string surname, string Age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = Age;       
                
    }

    public string Name { get; private set; }

    public string Surname { get; private set; }

    public string Age { get; private set; }

    public void AddScore(int number)
    {
        this.score.Add(number);
    }

    public int Result 
    { 
        get
        {
            return this.score.Sum();
        }
    }
    
}


