using System;
/*Problem 3. Divide by 7 and 5
                
    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
                
            Examples:
            n 	    Divided by 7 and 5?
            3 	    false
            0 	    false
            5 	    false
            7 	    false
            35 	    true
            140 	true*/
class DevideBySevenAndFive
{
    static void Main()
    {
        int firstDivider = 7;
        int secondDivider = 5;
        int userNumber; //Empty int to be used later
        Console.Write("Please enter your number: ");
        string userImput = Console.ReadLine();

        if (int.TryParse(userImput, out userNumber)) //Here I check is the userImput a number and if it's a number I assign it to userNumber.
        {
            bool check = userNumber % 7 == 0 && userNumber % 5 == 0;   //Here I make a bool variable to hold true/false value
            if (userNumber % 7 == 0 && userNumber % 5 == 0)     //With the operator % I check the output of the devider.
            {                       
                int result = userNumber / firstDivider;                                           
                int secondResult = userNumber / secondDivider;                                    
                Console.WriteLine(check);               //By task I need to output result as true or false so I make it here
                Console.WriteLine("Your number can be divided by 7 and 5.");
                Console.WriteLine("{0} / {1} = {2}", userNumber, firstDivider, result);
                Console.WriteLine("{0} / {1} = {2}", userNumber, secondDivider, secondResult);  
            }
            else
            {
                double result = (double)userNumber / firstDivider;
                double secondResult = (double)userNumber / secondDivider;
                Console.WriteLine(check);
                Console.WriteLine("Your number can't be divided by 7 and 5.");
                Console.WriteLine("{0} / {1} = {2}", userNumber, firstDivider, result);
                Console.WriteLine("{0} / {1} = {2}", userNumber, secondDivider, secondResult);
            }
        }
        else
        {
            Console.WriteLine("Your number is invalid!\nPlease try again!");
        }
    }
}
