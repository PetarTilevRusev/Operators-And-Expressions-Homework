using System;
                /* Problem 5. Third Digit is 7?
                
                    Write an expression that checks for given integer if its third digit from right-to-left is 7.
                
                        Examples:
                        n 	        Third digit 7?
                        5 	            false
                        701 	        true
                        9703 	        true
                        877 	        false
                        777877 	        false
                        9999799 	    true    */
class ThirdDigit
{
    static void Main()

    {
        int[] exampleNumbers = { 5, 701, 9703, 877, 777877, 9999799 }; //I use arrays again
        for (int i = 0; i < exampleNumbers.Length; i++) //I make "for" loop to check all the values in exampleNumbers variable
        {
            bool check = (exampleNumbers[i] / 100) % 10 == 7; 
            Console.WriteLine("Example {0}: Number = {1}. Is the third digit = 7 : {2}", i, exampleNumbers[i], check);
        }
        //Below I make the same thing but the imput is from the user.
        Console.Write("\nEnter your number: "); 
        string userImput = Console.ReadLine();
        int userNumber;
        if (int.TryParse(userImput, out userNumber)) //Here I check is the userImput a number
        {
            Console.Clear();
            bool check = (userNumber / 100) % 10 == 7;
            Console.WriteLine("Your number is {0}. \nIs the third digit = 7 ...... {1}", userNumber, check);
        }
        else
        {
            Console.WriteLine("You have entered a wrong number value!\nPlease try again!"); //If the user imput isn't a number, I nicely tell him to try again.
        }

    }
}

