using System;
using System.Collections.Generic;
using System.Reflection;

class Obj{
    public static void Print(object myObj)
    {
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (var prop in myObj.GetType().GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{myObj.GetType().Name} Methods:");

        foreach (var method in myObj.GetType().GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
