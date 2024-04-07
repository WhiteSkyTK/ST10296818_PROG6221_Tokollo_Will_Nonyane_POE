using ST10296818_PROG6221_Tokollo_Will_Nonyane_POE_Part_1;
using System;

namespace POE
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Methods.Start();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //Method used to add ingredients
                        Methods.add();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        End.close();
                        break;
                    default:
                        Console.WriteLine("Invaild option. Please pick a option shown above");
                        break;
                }
            }
            while (option != 6);
            
        }
    }
}


