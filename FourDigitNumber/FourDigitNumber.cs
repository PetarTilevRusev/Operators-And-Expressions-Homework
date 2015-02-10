using System;
                /*Problem 6. Four-Digit Number
                
                    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
                        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
                        Prints on the console the number in reversed order: dcba (in our example 1102).
                        Puts the last digit in the first position: dabc (in our example 1201).
                        Exchanges the second and the third digits: acbd (in our example 2101).
                
                        The number has always exactly 4 digits and cannot start with 0.
                
                        Examples:
                        n 	    sum of digits 	reversed 	last digit in front 	second and third digits exchanged
                        2011 	    4 	          1102      	1201                    	2101
                        3333 	    12 	          3333      	3333                    	3333
                        9876 	    30 	          6789      	6987                    	9786*/
class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Now let's play a bit with 4 digit numbers!");
        Console.WriteLine("Be aware: the number have to be from 1000 to 9999 and it can't start with 0!");
        Console.Write("Please enter your number: ");
        int userImput = int.Parse(Console.ReadLine());
        int a = (userImput / 1) % 10;
        int b = (userImput / 10) % 10;
        int c = (userImput / 100) % 10;
        int d = (userImput / 1000) % 10;
        string reversedNumber = Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c) + Convert.ToString(d);
        string lastDigitInFront = Convert.ToString(d) + Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c);
        string digitExchange = Convert.ToString(a) + Convert.ToString(c) + Convert.ToString(b) + Convert.ToString(d);
        string numberLenght = Convert.ToString(userImput);
        if (numberLenght.Length == 4)
        {
            int calculation = a + b + c + d;
            Console.WriteLine("Your number digit + digit is: {0}", calculation);
            Console.WriteLine("Your number reversed is: {0}", reversedNumber);
            Console.WriteLine("Your number with lasd digit in front: {0}", lastDigitInFront);
            Console.WriteLine("Your number with second and third digit exchanged: {0}", digitExchange);
        }
        else
        {
            Console.WriteLine("Your number need to be 4 digits long!");
        }
    }
}

