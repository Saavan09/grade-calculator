/*

Name: Saavan Tandon
Class: 8am Tues/Fri with Nick
Due Date: Sunday 10/13

*/

using System;

class Program 
{
    public static void Main(string[] args)
    {
        string name = "Saavan";
        int[] grades = {100, 92, 87, 200, -20, 52, 82, 75, 67, 88};

        Console.WriteLine("Welcome to the student portal, " + name + "!");
        Console.WriteLine("Here are your grades: ");

        for(int i=0; i<grades.Length; i++)
        {
            Console.Write(grades[i] + " ");
        }
    }
}