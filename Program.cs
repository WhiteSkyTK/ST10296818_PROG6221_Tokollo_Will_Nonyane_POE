using ST10296818_PROG6221_Tokollo_Will_Nonyane_POE_Part_1;
using System;

namespace POE
{
    class Program
    {
        static void Main(string[] args)
        {
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
                            Console.WriteLine("\nInvaild option. Please pick a valid option"); //
                            break;
                    }
                }
                catch(FormatException) //
                {
                    Console.WriteLine("\nInvaild option. PLease pick a valid option");
                    option = -1; //set it to a invalid value so it can loop
                }
                catch(Exception ex) //
                {
                    Console.WriteLine($"\nAn error occurred: {ex.Message}");
                    option = -1; //set it to a invalid value so it can loop
                }
            }
            while (option != 7);
        }
    }
}


