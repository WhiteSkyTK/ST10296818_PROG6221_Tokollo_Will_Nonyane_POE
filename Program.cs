using ST10296818_PROG6221_Tokollo_Will_Nonyane_POE_Part_1;
using System;

namespace POE
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Messages.Welcome();
            do
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
                        Methods.Display();
                        break;
                    case 3:
                        Methods.Scale();
                        break;
                    case 4:
                        Methods.DeleteRecipe();
                        break;
                    case 5:
                        Methods.DeleteAll();
                        break;
                    case 6:
                        Methods.close();
                        break;
                    default:
                        Console.WriteLine("\nInvaild option. Please pick a vaild option");
                        break;
                }
            }
            while (option != 6);
            
        }
    }
}


