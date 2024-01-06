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
