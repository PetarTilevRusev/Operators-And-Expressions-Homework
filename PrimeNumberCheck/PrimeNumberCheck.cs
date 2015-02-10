using System;
                /*Problem 8. Prime Number Check
                
                    Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
                    Note: You should check if the number is positive
                
                        Examples:
                        n 	    Prime?
                        1 	    false
                        2 	    true
                        3 	    true
                        4 	    false
                        9 	    false
                        97 	    true
                        51 	    false
                        -3 	    false
                        0 	    false*/
class Program
{
    static void Main()
    {
        int userNumber = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (userNumber > 0 && userNumber <= 100)
        {
            for (int i = 2; i < 10; i++)
            {
                if (userNumber != i)
                {
                    if (userNumber % i == 0)
                    {
                        isPrime = false;
                    }
                    
                }
                Console.WriteLine("Is your number prime: {0}", isPrime);
            }
        }
        else
        {
            isPrime = false;
            Console.WriteLine("Is your number prime: {0}", isPrime);
        }
    }
}

