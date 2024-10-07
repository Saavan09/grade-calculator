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

            else if (89 >= grades[i] && grades[i] >= 80) //between 80 and 89
            {
                Console.WriteLine(grades[i] + ": This grade is a B.");
            }

            else if (79 >= grades[i] && grades[i] >= 70) //between 70 and 79
            {
                Console.WriteLine(grades[i] + ": This grade is a C.");
            }

            else if (69 >= grades[i] && grades[i] >= 65) //between 65 and 60
            {
                Console.WriteLine(grades[i] + ": This grade is a D.");
            }

            else if (64 >= grades[i] && grades[i] >= 0) //between 0 and 64
            {
                Console.WriteLine(grades[i] + ": This grade is an F.");
            }

            else //anything outside the range of 0-100
            {
                Console.WriteLine(grades[i] + ": This is out of the range of 0-100. How did you even get this grade?");
            }
        }

        double average = 0;

        for(int i=0; i<grades.Length; i++)
        {
            average += grades[i];
        }

        average = average / grades.Length;

        Console.WriteLine("Your final calculated average is " + average + ".");
        Console.WriteLine("All grades for " + name + " have been displayed.");

        Console.ReadKey();
    }
}