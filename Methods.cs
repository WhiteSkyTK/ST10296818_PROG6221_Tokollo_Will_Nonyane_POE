using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10296818_PROG6221_Tokollo_Will_Nonyane_POE_Part_1
{
    internal class Methods
    {
        public static void close()
        {
            Console.WriteLine("Thank you for using the system");
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        public static void Start()
        {
            Methods.Welcome();

            Methods.Option();
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome user to recipez");
            Console.WriteLine("A place where you can find all types of recipes");
        }

        public static void Option()
        {
            Console.Write("What would you like to do" + "\n" +
                "1. Add a new recipe" + "\n" +
                "2. Display recipe" + "\n" +
                "3. Scale recipe" + "\n" +
                "4. Delete recipe" + "\n" +
                "5. Clear all data" + "\n" +
                "6. Close the program" + "\n" +
                "Option:");
        }
    }
}
