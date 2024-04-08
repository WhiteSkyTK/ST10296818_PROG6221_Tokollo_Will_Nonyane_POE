using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10296818_PROG6221_Tokollo_Will_Nonyane_POE_Part_1
{
    internal class Methods
    {
        private static List<Ingredient> ingredients = new List<Ingredient>();
        private static List<Step> steps = new List<Step>();
        public static void Display()
        {
            if(ingredients.Count == 0 && steps.Count == 0)
            {
                Console.WriteLine("No recipes available");
                return;
            }

            Console.WriteLine("Ingredient:");
            foreach(Ingredient ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine("\nSteps:");
            for(int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }
        }
        public static void Scale()
        {

        }
        public static void DeleteRecipe()
        {

        }
        public static void DeleteAll()
        {

        }
        
        public static void close()
        {
            Console.WriteLine("Thank you for using the system");
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        public static void Start()
        {
            Methods.Option();
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

        public static void add()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            List<Step> steps = new List<Step>();

            //Number of ingredients
            Console.Write("Please enter the number of ingredients: ");
            int numIngredints = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numIngredints; i++)
            {
                //Name of ingredints
                Console.WriteLine();
                Console.Write("Enter the name of the ingredient: ");
                string Name = Console.ReadLine();

                //Quantity
                Console.WriteLine();
                Console.Write("Enter the quantity: ");
                int Quantity = Convert.ToInt32(Console.ReadLine());

                //Unit of measure
                Console.WriteLine();
                Messages.Unit();
                int pick = Convert.ToInt32(Console.ReadLine());
                string Unit;
                switch (pick)
                {
                    case 1:
                        Unit = "Milliliters";
                        break;
                    case 2:
                        Unit = "Liters";
                        break;
                    case 3:
                        Unit = "Teaspoons";
                        break;
                    case 4:
                        Unit = "Tablespoons";
                        break;
                    case 5:
                        Unit = "Cups";
                        break;
                    case 6:
                        Console.WriteLine("Please enter a unit of measurement");
                        Unit = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please pick a vaild value");
                        Unit = "Unknown";
                        break;
                }

                ingredients.Add(new Ingredient(Name, Quantity, Unit));
            }
            
            //number of steps
            Console.WriteLine();
            Console.WriteLine("Please enter the number of steps");
            int numStep = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numStep; i++)
            {
                //Description for the steps
                Console.WriteLine();
                Console.WriteLine("A description of what the user should do");
                String description = Console.ReadLine();
                steps.Add(new Step(description));  
            }
        }
    }
    class Messages
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome user to recipez");
            Console.WriteLine("A place where you can find all types of recipes");
        }
        public static void Unit()
        {
            Console.Write("Please pick a unit of measure" + "\n" +
                "1. Milliliters (ml)" + "\n" +
                "2. Liters (l)" + "\n" +
                "3. Teaspoons (tsp)" + "\n" +
                "4. Tablespoons (tbsp)" + "\n" +
                "5. Cups" + "\n" +
                "6. Others" + "\n" +
                "Option:");
        }
    }

    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }

    class Step
    {
        public string Description { get; set; }

        public Step(string description)
        {
            Description = description; 
        }
    }

    

}
