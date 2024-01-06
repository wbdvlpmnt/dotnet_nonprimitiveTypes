﻿using nonprimitive.calculator;

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


    }
}
