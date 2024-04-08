using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10296818_PROG6221_Tokollo_Will_Nonyane_POE_Part_1
{
    internal class Methods
    {
        //(Declearation) Arraylist added to store Ingredient and orginal values entered
        private static List<Ingredient> ingredients = new List<Ingredient>();
        private static List<Step> steps = new List<Step>();
        private static List<Ingredient> originalQuantities = new List<Ingredient>();

        //Display method used to display all values
        public static void Display()
        {
            //Dash string used for the interface of the program
            string dash = "------------------------------------------------------------";
            
            //If statement used to check if any values in the array
            if (ingredients.Count == 0 && steps.Count == 0)
            {
                Console.WriteLine("No recipes available to display.");
                return;
            }

            //Interface and the display (with uses a foreach loop and a for loop)
            Console.WriteLine(dash + "\nDisplay:\n" + dash + "\nIngredient:");
            foreach(Ingredient ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine("\nSteps:");
            for(int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }
            Console.WriteLine(dash + "\n");
        }

        //Scaling method to scale up or down the recipes ingredeint
        public static void Scale()
        {
            //Dash string for the interface and if statement to check if there is any values in the arraylist
            string dash = "-------------------------------------------------------------";
            if (ingredients.Count == 0 && steps.Count == 0)
            {
                Console.WriteLine("No recipes available to scale.");
                return;
            }

            //Calling the display menu for the scales
            Methods.scaleOption();

            //Declearation
            double factor;
            int scaling = Convert.ToInt32(Console.ReadLine()); //input for selecting the option of scaling needed

            //switch method to choose a scale
            switch (scaling)
            {
                case 1:
                    factor = 1.0; //default value
                    break;
                case 2:
                    factor = 2.0; //double the value
                    break;
                case 3:
                    factor = 3.0; // triple the value
                    break;
                case 4:
                    factor = 0.5; // half the value
                    break;
                default:
                    Console.WriteLine("Invalid scaling factor."); //invalid option
                    return;
            }

            //for loop to scale all values in the arraylist
            foreach(Ingredient ingredient in ingredients)
            {
                ingredient.Quantity *= factor; //Calculation
            }

            //write line statement which tells the user that everything is good
            Console.WriteLine($"Recipe scaled by a factor of {factor}.");
        }

        //Delete recipe method used to delete a recipe(COMING SOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOON)
        public static void DeleteRecipe()
        {
            //Used for the interface of the program
            string dash = "------------------------------------------------------------";
            
            //if statemant which checks if the are any values in the arraylist
            if (ingredients.Count == 0 && steps.Count == 0)
            {
                Console.WriteLine("No recipes available to delete.");
                return;
            }
            Console.WriteLine("Feature is not available (Coming Soon)");
        }

        //Method to delete all recipes 
        public static void DeleteAll()
        {
            //used foe the interface of the program
            string dash = "------------------------------------------------------------";
            
            //if statement to check if there is any values in the arraylist
            if (ingredients.Count == 0 && steps.Count == 0)
            {
                Console.WriteLine("No recipes available to delete");
                return;
            }

            //Are you sure message
            Console.Write("Are you sure you want to delete all recipe\n" +
                "1. Yes\n" +
                "2. No\n" +
                "Option: ");
            int num = Convert.ToInt32(Console.ReadLine()); //input
            switch(num)
            {
                case 1:
                    //Clears all the values in a arraylist
                    ingredients.Clear();
                    steps.Clear();
                    originalQuantities.Clear();
                    Console.WriteLine("All recipes have been deleted.");
                    break;
                case 2:
                    break;
            }
        }

        //Reset scale method
        public static void resetScale()
        {
            //if statement that check if there any values in the arraylist
            if(ingredients.Count == 0)
            {
                Console.WriteLine("No recipe available to reset scale.");
                return;
            }

            //Loop that scales all quantities
            for(int i = 0; i < ingredients.Count; i++)
            {
                ingredients[i].Quantity = originalQuantities[i].Quantity;
            }
            //tells the user that everything is fine.
            Console.WriteLine("Scale reset to original values.");
        }
        
        //method used to close the program
        public static void close()
        {
            Console.WriteLine("Thank you for using the system\n" + "Press any key to close");
            Console.ReadKey();
        }

        //Methods to start the program and contains all the methods
        public static void Start()
        {
            Methods.Option(); //option menu
        }

        //Method to display the main option menu
        public static void Option()
        {
            //Used for the interface
            string dash = "-------------------------------------------------------------";
            
            Console.Write(dash + "\nWhat would you like to do" + "\n" +
                "1. Add a new recipe" + "\n" +
                "2. Display recipe" + "\n" +
                "3. Scale recipe" + "\n" +
                "4. Original scale" + "\n" +
                "5. Delete recipe" + "\n" +
                "6. Clear all data" + "\n" +
                "7. Close the program" + "\n" +
                "Option: ");
        }

        //Method to display the option menu for the scaling
        public static void scaleOption()
        {
            //used for the interface 
            string dash = "-------------------------------------------------------------";
            
            Console.Write(dash +"\nWhat would you like to do" + "\n" +
                "1. Factor of 1 (Default)" + "\n" +
                "2. Factor of 2 (Double)" + "\n" +
                "3. Factor of 3 (Triple)" + "\n" +
                "4. Factor of 0.5 (Half)" + "\n" +
                "Option: ");
        }

        //Method used to input recipe
        public static void add()
        {
            //Used for the interface6
            string dash = "-------------------------------------------------------------";

            //decleartion
            int numIngredints;
            //Do loop which ensure that the user enters the correct vaule
            do
            {
                Console.Write("Please enter the number of ingredients needed: ");
                if (!int.TryParse(Console.ReadLine(), out numIngredints) || numIngredints <= 0) //input for the number of ingredients needed
                {
                    Console.WriteLine("Invalid input. Please enter a vaild integer.");
                }
            }
            while(numIngredints <= 0);
                
            //Try and catch to handle human errors
            try
            { 
                //For loop for the number of ingredients needed
                for (int i = 0; i < numIngredints; i++)
                {
                    string Name; //decleartion
                    //Do loop which checks for whitespaces
                    do
                    {
                        //Name of ingredints
                        Console.WriteLine(); // line break
                        Console.Write("Enter the name of the ingredient: ");
                        Name = Console.ReadLine(); //input for the name of the ingredient 
                        if (string.IsNullOrWhiteSpace(Name))
                        {
                            Console.WriteLine("Ingredient name cannot be blank. Please enter a valid name.");
                        }
                    }
                    while (string.IsNullOrWhiteSpace(Name));

                    string Unit; //declearation for unit
                    //Do loop which loop on error
                    do
                    {
                        //Unit of measure
                        Console.WriteLine(); //line break
                        Messages.Unit(); //calling display menu for the units of measure
                        int pick; 
                        if (int.TryParse(Console.ReadLine(), out pick) && pick >= 1 && pick <= 4) //input for unit option
                        {
                            //switch for unit options
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
                                    throw new ArgumentOutOfRangeException(); //
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid option (1-4).");
                            Unit = null; //Set unit to null so it can loop
                        }
                    }
                    while (Unit == null);

                    double Quantity; //decleartion
                    //Do loop which loops on error
                    do
                    {
                        //Quantity
                        Console.Write("\nEnter the quantity for " + Name + " (Only a interger): ");
                        if (!double.TryParse(Console.ReadLine(), out Quantity) || Quantity <= 0) //input for quantity
                        {
                            Console.WriteLine("Invalid input. Please enter a valid positive number.");
                        }
                    } 
                    while (Quantity <= 0);

                    ingredients.Add(new Ingredient(Name, Quantity, Unit)); //adds the name, quantity and unit to the arraylist
                    Console.WriteLine(dash + "\nIngredient " + (i + 1) + " Has Been Saved\n" + dash); //interface layout

                    // Add original quantities to the arraylist
                    originalQuantities.AddRange(ingredients.Select(i => new Ingredient(i.Name, i.Quantity, i.Unit)));
                }

                int numStep; //decleartion
                //Do loop which loops on error
                do
                {
                    //number of steps
                    Console.Write("\nPlease enter the number of steps: ");
                    if (!int.TryParse(Console.ReadLine(), out numStep) || numStep <= 0)  //input for number of steps 

                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                } 
                while (numStep <= 0);
                
                //For loop to enter the number of steps required
                for (int i = 0; i < numStep; i++)
                {
                    string description; //decleartion
                    //Do loop on error
                    do
                    {
                        //Description for the steps
                        Console.Write("\nPlease enter the description of what to do: ");
                        description = Console.ReadLine().Trim(); //input and trim method to remove extra whitespaces
                        if (string.IsNullOrWhiteSpace(description))
                        {
                            Console.WriteLine("Step description cannot be blank. Please enter a valid description.");
                        }
                    }
                    while (string.IsNullOrWhiteSpace(description));
                    
                    Console.WriteLine(); //line break
                    steps.Add(new Step(description)); //Add to the arraylist

                    //Show user which step they are on
                    Console.WriteLine("\nStep " + (i + 1) + " Has Been Saved");
                }
                //Write line statement to notify user that every is good
                Console.WriteLine("\nInformation has been saved successfully");
            }
            //This catchs invalid inputs for integers
            catch(FormatException)
            {
                Console.WriteLine("Invaild input. Please enter a valid number.");
            }

            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            //This catchs all types of errors
            catch (Exception) 
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }

    //Class which stores messasges and menu options
    class Messages
    {
        //method of the welcome screen
        public static void Welcome()
        {
            Console.WriteLine("Welcome user to recipez!!!!" + 
                "\nA place where you can find all types of recipes");
        }

        //method of the display menu for the unit of measure
        public static void Unit()
        {
            Console.Write("Please pick a unit of measure" + "\n" +
                "1. Teaspoons (tsp)" + "\n" +
                "2. Tablespoons (tbsp)" + "\n" +
                "3. Cups" + "\n" +
                "4. Others" + "\n" +
                "Option: ");
        }
    }

    //Class which stores the ingredients name, quantity, unit (Using getters and setters)
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

    //Class which store the steps description (Using getters and setters)
    class Step
    {
        public string Description { get; set; }

        public Step(string description)
        {
            Description = description; 
        }
    }
}