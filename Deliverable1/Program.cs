using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello! This code will be a vacation calculator based on the information given in each senctence.
            // First it will ask what type of vacation you would like based off three types.
            Console.WriteLine("What type of trip would you like to go on? Musical, Tropical, or Adventurous?");
            string vacationType = Console.ReadLine();

            // Then the next question is asked, takes the number given and transfers the writing into an integer.
            Console.WriteLine("How many are in your group? (use a number please or everything's ruined)");
            int groupSize = int.Parse(Console.ReadLine());

            // Now we create the result string. This will be adjusted based on the 'if-else' statements in a second.
            string result = "";


            // ALL of these if and else if statements relate to the sencond half of the sentence.
            // It takes the type of vacationType and groupSize taken of each, and writes a new statement with the result and 
            // added information

            if ((vacationType == "musical" || vacationType == "Musical") && (groupSize >= 1 && groupSize <= 2))
            {
                result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation,\nyou should take first class to New Orleans!";
            }
            else if ((vacationType == "musical" || vacationType == "Musical") && (groupSize >= 3 && groupSize <= 5))
            {
                result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation,\nyou should take a helicopter to New Orleans!";
            }
            else if ((vacationType == "musical" || vacationType == "Musical") && (groupSize >= 6))
            {
                result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation,\nyou should take a charter flight to New Orleans!";
            }
            
            if ((vacationType == "tropical" || vacationType == "Tropical") && (groupSize >= 1 && groupSize <= 2))
            {
                result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation,\nyou should take first class to a Beach Vacation in Mexico!";
            }
            else if ((vacationType == "tropical" || vacationType == "Tropical") && (groupSize >= 1 && groupSize <= 2))
            {
                result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation,\nyou should take a helicopter to a Beach Vacation in Mexico!";
            }
            else if ((vacationType == "tropical" || vacationType == "Tropical") && (groupSize >= 6)) 
            {
                result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation,\nyou should take a charter flight to a Beach Vacation in Mexico!";
            }

            if ((vacationType == "adventurous" || vacationType == "Adventurous") && (groupSize >= 1 && groupSize <= 2))
            {
                result = "Since you're a group of " + groupSize + " going on an " + vacationType + " vacation,\nyou should take first class to Whitewater Rafting the Grand Canyon!";
            }
            else if ((vacationType == "adventurous" || vacationType == "Adventurous") && (groupSize >= 3 && groupSize <= 5))
            {
                result = "Since you're a group of " + groupSize + " going on an " + vacationType + " vacation,\nyou should take a helicopter to Whitewater Rafting the Grand Canyon!";
            }
            else if ((vacationType == "adventurous" || vacationType == "Adventurous") && (groupSize >= 6))
            {
                result = "Since you're a group of " + groupSize + " going on an " + vacationType + " vacation,\nyou should take a charter flight to Whitewater Rafting the Grand Canyon!";
            }
            // Now for the official print of the code! The \n is to separate it from the remaining information. More readable.
            Console.Write(result +"\n");

            // And that's how it works!
        }
    }
}


