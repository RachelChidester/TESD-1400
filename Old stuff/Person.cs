// Excercises: Clases

// Person Basics

public class Person
{
   public string Name;
   private int age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
   public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be negative.");
            }
            age = value;
        }
    }
    
    public bool IsAdult
    {
        get
        {
            return Age >= 18;
        }
    }

    public bool IsOlderThat(Person other)
    {
        return this.Age > other.Age;
    }
    public override string ToString()
    {
        return $"{Name}, {Age}";
    }
    public static void GreetAll(List<Person> people)
    {
        foreach (Person person in people)
        {
            person.Introduce();
        }
    }
    public string HappyBirthday()
    {
        Age++;
        return $"Happy birthday, {Name}! You are now {Age} years old!";
    }
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old");
    }
}

