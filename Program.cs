using nonprimitive.calculator;

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
        Console.WriteLine(result);

        // Example of using a struct 
        RgbColor rgb = new RgbColor();
        rgb.Red = 1;
        rgb.Blue = 2;
        rgb.Green = 3;
        System.Console.WriteLine(rgb.Red);

        // Arrays
        int[] numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        System.Console.WriteLine(numbers[0]);
        System.Console.WriteLine(numbers[1]);
        System.Console.WriteLine(numbers[2]);

        var names = new string[3] { "Jack", "john", "mary" };
        System.Console.WriteLine(names[0]);
        System.Console.WriteLine(names[1]);
        System.Console.WriteLine(names[2]);

        // strings
        string name = string.Format("{0} {1}", "firstName", "lastName");
        System.Console.WriteLine(name);

        string path = @"c:\\projects\project1\Program.cs"; // verbatim string
        System.Console.WriteLine(path);

    }
}
