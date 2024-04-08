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
            string dash = "------------------------------------------------------------";
            if (ingredients.Count == 0 && steps.Count == 0)
            {
                Console.WriteLine("No recipes available");
                return;
            }

            Console.WriteLine(dash);
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
            Console.WriteLine(dash);
            Console.WriteLine();
        }
        public static void Scale()
        {
            string dash = "-------------------------------------------------------------";
            if (ingredients.Count == 0 && steps.Count == 0)
            {
                Console.WriteLine("No recipes available to scale");
                return;
            }
            Methods.scaleOption();
            double factor;
            int scaling = Convert.ToInt32(Console.ReadLine());

            switch (scaling)
            {
                case 1:
                    factor = 1.0;
                    break;
                case 2:
                    factor = 2.0;
                    break;
                case 3:
                    factor = 3.0;
                    break;
                case 4:
                    factor = 0.5;
                    break;
                default:
                    Console.WriteLine("Invalid scaling factor.");
                    return;
            }

            foreach(Ingredient ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }

            Console.WriteLine($"Recipe scaled by a factor of {factor}.");
        }
        public static void DeleteRecipe()
        {

        }
        public static void DeleteAll()
        {

        }

        public static void resetScale()
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
            string dash = "-------------------------------------------------------------";
            Console.WriteLine(dash);
            Console.Write("What would you like to do" + "\n" +
                "1. Add a new recipe" + "\n" +
                "2. Display recipe" + "\n" +
                "3. Scale recipe" + "\n" +
                "4. Original scale" + "\n" +
                "5. Delete recipe" + "\n" +
                "6. Clear all data" + "\n" +
                "7. Close the program" + "\n" +
                "Option:");
        }

        public static void scaleOption()
        {
            string dash = "-------------------------------------------------------------";
            Console.WriteLine(dash);
            Console.Write("What would you like to do" + "\n" +
                "1. Factor of 1 (Default)" + "\n" +
                "2. Factor of 2 (Double)" + "\n" +
                "3. Factor of 3 (Triple)" + "\n" +
                "4. Factor of 0.5 (Half)" + "\n" +
                "Option:");
        }

        public static void add()
        {
            string dash = "-------------------------------------------------------------";
            //Number of ingredients
            Console.Write("Please enter the number of ingredients needed: ");
            int numIngredints = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numIngredints; i++)
            {
                //Name of ingredints
                Console.WriteLine();
                Console.Write("Enter the name of the ingredient: ");
                string Name = Console.ReadLine();

                //Unit of measure
                Console.WriteLine();
                Messages.Unit();
                int pick = Convert.ToInt32(Console.ReadLine());
                string Unit;
                switch (pick)
                {
                    case 1:
                        Unit = "Teaspoons";
                        break;
                    case 2:
                        Unit = "Tablespoons";
                        break;
                    case 3:
                        Unit = "Cups";
                        break;
                    case 4:
                        Console.WriteLine("Please enter a unit of measurement");
                        Unit = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please pick a vaild value");
                        Unit = "Unknown";
                        break;
                }

                //Quantity
                Console.WriteLine();
                Console.Write("Enter the quantity (Only a interger): ");
                int Quantity = Convert.ToInt32(Console.ReadLine());

                ingredients.Add(new Ingredient(Name, Quantity, Unit));
                Console.WriteLine(dash);
                Console.WriteLine("\nIngredient " + (i + 1) + " Has Been Saved");
                Console.WriteLine(dash);
            }
            
            //number of steps
            Console.WriteLine();
            Console.Write("Please enter the number of steps:");
            int numStep = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numStep; i++)
            {
                //Description for the steps
                Console.WriteLine();
                Console.Write("Please enter the description of what to do:");
                String description = Console.ReadLine();
                Console.WriteLine();
                steps.Add(new Step(description));
                Console.WriteLine("\nStep " + (i + 1) + " Has Been Saved");
            }
            Console.WriteLine("\nInformation has been saved successfully");
        }
    }
    class Messages
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome user to recipez!!!!");
            Console.WriteLine("A place where you can find all types of recipes");
        }
        public static void Unit()
        {
            Console.Write("Please pick a unit of measure" + "\n" +
                "1. Teaspoons (tsp)" + "\n" +
                "2. Tablespoons (tbsp)" + "\n" +
                "3. Cups" + "\n" +
                "4. Others" + "\n" +
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
