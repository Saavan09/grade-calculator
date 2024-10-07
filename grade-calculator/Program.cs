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
            if(100 >= grades[i] && grades[i] >= 90) //between 90 and 100
            {
                if(grades[i] == 100)
                    Console.WriteLine(grades[i] + ": WOW! A perfect score!");
                else
                    Console.WriteLine(grades[i] + ": This grade is an A.");
            }

            else if (89 >= grades[i] && grades[i] >= 80)
            {
                Console.WriteLine(grades[i] + ": This grade is a B.");
            }

            else if (79 >= grades[i] && grades[i] >= 70)
            {
                Console.WriteLine(grades[i] + ": This grade is a C.");
            }

            else if (69 >= grades[i] && grades[i] >= 65)
            {
                Console.WriteLine(grades[i] + ": This grade is a D.");
            }

            else if (64 >= grades[i] && grades[i] >= 0)
            {
                Console.WriteLine(grades[i] + ": This grade is an F.");
            }

            else
            {
                Console.WriteLine(grades[i] + ": This is out of the range of 0-100. How did you even get this grade?");
            }
        }
    }
}