using System;
                /*Problem 4. Rectangles
                
                    Write an expression that calculates rectangle’s perimeter and area by given width and height.
                
                            Examples:
                                width 	height 	perimeter 	area
                                3 	     4 	     14 	    12
                                2.5      3 	     11  	    7.5
                                5 	     5 	     20 	    25*/
class Rectangles
{
    static void Main()
    {
        float[] exampleWidth = { 3f, 2.5f, 5f }; //Using arrays is more easy to set a multiple values to one variable.
        float[] exampleHeight = { 4f, 3f, 5f, }; 
        for (int i = 0; i < exampleWidth.Length; i++)
        {
            for (int e = 0; e < exampleHeight.Length; e++)
            {
                float exampleArea =(exampleWidth[i] * exampleHeight[e]);            //This is the formula to calculate triangle area. (Area = Width * Height)
                float exampleHypotenuse = (exampleWidth[i] + exampleHeight[i]);     //I need to find the hypotenuse (the third side) to be able to find the triangle's perimeter. (Hypotenuse = Width + Height)
                float examplePerimeter = exampleHypotenuse + exampleWidth[i] + exampleHeight[i];    //Now I can easily find the perimeter. (Perimeter = Hypotenuse + Width + Height)
                Console.WriteLine("Width: {0} Height: {1} Area: {2} Perimeter: {3}",exampleWidth[i], exampleHeight[e], exampleArea, examplePerimeter);
                i++;
            }
            break; //This break is to exit the first "for" loop.
        }
        Console.WriteLine(new string('-', 80));
        Console.WriteLine("Do you wanna calcualte your oun triangle?");
        Console.Write("Yes or No: ");
        string userAnswer = Console.ReadLine(); //Taking the user answer here 
        Console.Clear();
        if (userAnswer == "Yes" || userAnswer == "yes") //Checking the user answer Yes or yes
        {
            float width;      //Empty floats to hold the user values
            float height;
            Console.Write("Triangle width: ");
            string userWidth = Console.ReadLine();  //Taking the user values
            Console.Write("Triange height: ");
            string userHeight = Console.ReadLine();
            if (float.TryParse(userWidth, out width) && float.TryParse(userHeight, out height)) //Checking the user values, can they be converted to float
            {
                //Calculating
                float area = width * height;
                float hypotenuse = width + height;
                float perimeter = hypotenuse + width + height;
                //Printing
                Console.WriteLine("Triangle area: {0} \nTriangle perimeter: {1}", area, perimeter);
                Console.WriteLine("Have a nice day!");
            }

        }
        else if (userAnswer == "No" || userAnswer == "no") //Checking the user answer No or no
        {
            Console.WriteLine("Have a nice day!");
        }
        else  //Output if the user answer isn't yes or no
        {
            Console.WriteLine("Please enter a valid answer!"); 
        }
    }
}

