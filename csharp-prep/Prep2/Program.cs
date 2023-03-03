using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grad percentage? ");
        String userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        if (percentage >= 90 )
        {
            Console.WriteLine("Your grade letter is A.");
        }
        else if (percentage >= 80 &&  percentage < 90 )
        {
            Console.WriteLine("Your grade letter is B.");
        }
        else if (percentage >= 70 &&  percentage < 80 )
        {
            Console.WriteLine("Your grade letter is C.");
        }
        else if (percentage >= 60 &&  percentage < 70 )
        {
            Console.WriteLine("Your grade letter is D.");
        }
        else 
        {
            Console.WriteLine("Your grade letter is F.");
        }
       
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations you have passed the course.");
        }   
        else
        {
            Console.WriteLine("Sorry, You must take the quiz again");
        }
            
    }

}