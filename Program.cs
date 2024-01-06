namespace nonprimitive;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Introduce();

        // var keyword to allocate memory
        var person1 = new Person();
        person1.Name = "Jaidev";
        person1.Introduce();

    }
}

public class Person
{
    public string Name = "Jai";

    public void Introduce()
    {
        System.Console.WriteLine("Hi, my name is " + Name);
    }
}