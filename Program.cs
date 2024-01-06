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

        // using the static keyword, 
        // no need to create a new obj
        int result = Calculator.Add(1, 2);
        System.Console.WriteLine(result);

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

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}