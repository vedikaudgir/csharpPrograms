using System;

class Placeholders
{
    static void Main()
    {
        Console.WriteLine("Enter your Name: ");
        string userName = Console.ReadLine();

        Console.WriteLine("Enter your last Name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Hello {0} {1}", userName, lastName); //String concatenation using a placeholder {0}.
    }
}