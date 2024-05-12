using ST10296818_PROG6221_Tokollo_Will_Nonyane_POE_Part_1;
using System;
using System.Collections.Generic;

namespace POE
{
    class Program
    {
        // List to store recipes
        static List<Recipe> recipes = new List<Recipe>(); 

        static void Main(string[] args)
        {
            // Subscribe to the NotifyExceedingCalories event
            Methods.NotifyExceedingCalories += NotifyExceedingCaloriesHandler;
            int option; //declearation
            Messages.Welcome(); //Method which hold the welcome message
            //Do loop which loops if an invaild input is entered
            do
            {
                //Try and catch method to catch human errors
                try
                {
                    Methods.Start();
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (option)
                    {
                        case 1:
                            //Method used to add ingredients
                            Methods.add();
                            break;
                        case 2:
                            //Display method
                            Methods.Display();
                            break;
                        case 3:
                            //scale up or down method
                            Methods.Scale();
                            break;
                        case 4:
                            //reset scale value method
                            Methods.resetScale();
                            break;
                        case 5:
                            //delete recipe method
                            Methods.DeleteRecipe();
                            break;
                        case 6:
                            //delete all method
                            Methods.DeleteAll();
                            break;
                        case 7:
                            //close program method
                            Methods.close();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red; //set color
                            Console.WriteLine("\nInvaild option. Please pick a valid option"); //
                            Console.ResetColor(); //reset color
                            break;
                    }
                }
                catch(FormatException) //
                {
                    Console.ForegroundColor = ConsoleColor.Red; //set color
                    Console.WriteLine("\nInvaild option. PLease pick a valid option");
                    Console.ResetColor(); //reset color
                    option = -1; //set it to a invalid value so it can loop
                }
                catch(Exception ex) //
                {
                    Console.ForegroundColor = ConsoleColor.Red; //set color
                    Console.WriteLine($"\nAn error occurred: {ex.Message}");
                    Console.ResetColor(); //Resetcolor
                    option = -1; //set it to a invalid value so it can loop
                }
            }
            while (option != 7);
        }
        // Event handler for exceeding calories notification
        private static void NotifyExceedingCaloriesHandler(string recipeName, double totalCalories)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string impactMessage;
            if (totalCalories <= 100)
            {
                impactMessage = $"This recipe '{recipeName}'is low in calories and suitable for maintaining a balanced diet.";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(impactMessage);
                Console.ResetColor();
            }
            else if (totalCalories <= 150)
            {
                impactMessage = $"This recipe '{recipeName}'e provides a moderate amount of calories and can contribute to a healthy meal.";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(impactMessage);
                Console.ResetColor();
            }
            else if (totalCalories <= 200)
            {
                impactMessage = $"This recipe '{recipeName}' provides a reasonable amount of calories, ideal for a satisfying meal.";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(impactMessage);
                Console.ResetColor();
            }
            else if (totalCalories <= 250)
            {
                impactMessage = $"This recipe '{recipeName}' contains a moderate to high amount of calories and can serve as a substantial meal.";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(impactMessage);
                Console.ResetColor();
            }
            else if (totalCalories > 300)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                impactMessage = $"Alret : The recipe '{recipeName}' has exceeded 300 calories." +
                    $"\nThe recipe is high in enery density." +
                    $"Note: This may contribute to weight gain if consumed regularly. Consider moderation.";
                Console.WriteLine(impactMessage);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("There is a error in the calories inputed");
                Console.ResetColor();
            }
        }

    }
}


