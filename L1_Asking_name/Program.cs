using System;

class HelloStranger
{
    static void Main()
    {
        string answer;
        Console.Write("Indentify yourself: "); 
        answer = Console.ReadLine(); // ask for input
        Console.WriteLine("Nice to meet you " + answer); // Make a new line
    }
}