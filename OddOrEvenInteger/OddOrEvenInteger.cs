using System;
                /*Problem 1. Odd or Even Integers
                
                    Write an expression that checks if given integer is odd or even.
                
                Examples:
                n 	Odd?
                3 	true
                2 	false
                -2 	false
                -1 	true
                0 	false*/
class OddOrEvenInteger
{
    static void Main()
    {
        int[] examples = { 3, 2, -2, -1, 0 }; //Here I check the examples

        for (int i = 0; i < 5; i++)
        {
            bool check = examples[i] % 2 != 0;
            Console.WriteLine("Is the number {0} odd? - {1}", examples[i], check);
        }

        Console.Write("Check your number, is it odd or even.\nYour number:");
        string userImput = Console.ReadLine();
        int userNumber;
        if (int.TryParse(userImput, out userNumber))
        {
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("The number {0} is even. \nThank you and have a nice day!", userNumber);
            }
            else
            {
                Console.WriteLine("The number {0} is odd. \nThank you and have a nice day!", userNumber);
            }
        }
        else
        {
            Console.WriteLine("Your number is invalid! \nPlease try again!");
        }
    }
}

