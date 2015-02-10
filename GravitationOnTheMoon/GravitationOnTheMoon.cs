using System;
                /*Problem 2. Gravitation on the Moon
                
                    The gravitational field of the Moon is approximately 17% of that on the Earth.
                    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
                
                        Examples:
                        weight 	weight on the Moon
                        86 	       14.62
                        74.6 	   12.682
                        53.7 	   9.129*/
class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Let's fidn out what is your weight on the Moon!");
        Console.Write("Your weight: ");
        
        string userImput = Console.ReadLine();      //I know I can parse here. But I don't want to.
        float moonWeightPercentage = 17f;
        
        float weight;      //Creating new float to hold the userImput value
        
        if (float.TryParse(userImput, out weight))    //Just a simple check of the user imput, to avoid error. Also here is the "float weight" I created above.
        {
            Console.WriteLine("Just a few examples to check the program algorithm");
            Console.WriteLine();
            float[] exampleWeight = { 86f, 74.6f, 53.7f};  //I make this to check the given examples by task
            for (int i = 0; i < 3; i++)
            {
                float exampleUserWeight = (moonWeightPercentage / 100) * exampleWeight[i];
                Console.WriteLine("Weight on earth: {0}. Weight on the moon {1}.", exampleWeight[i], exampleUserWeight);
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 80));
            float userWeight = (moonWeightPercentage / 100) * weight;
            Console.WriteLine("Your weight on the moon will be: {0}kg \nThank you and have a nice day!", userWeight);
        }
        else
        {
            Console.WriteLine("Please enter a valid weight!");
        }
        
    }
}

