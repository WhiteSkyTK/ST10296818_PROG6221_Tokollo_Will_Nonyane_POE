Recipe Manager Application (Recipez) - Updated README
Welcome to the Recipe Manager application, also known as Recipez! This program allows users to manage recipes by adding, displaying, scaling, and deleting them. Users can input ingredients, quantities, and steps for a recipe, display the recipe details, scale the recipe quantities, delete a recipe, or clear all recipes from the database.

Features
Add Recipe
Users can add a new recipe by inputting ingredients, their quantities, and steps.

Display Recipe
Users can view the details of all saved recipes, including ingredient details, steps, and total calorie content.

Scale Recipe
Users can scale the quantities of ingredients in a recipe by a factor of 2, 3, or 0.5.

Delete Recipe
Users can delete individual recipes from the database.

Clear All Data
Users can delete all recipes from the database.

Reset Scale
Users can reset the scaled quantities of ingredients in a recipe back to their original values.

Calorie Notifications
The application provides notifications to the user about the calorie content of each recipe, helping users make informed dietary choices.

Food Group Filtering
Recipes can be filtered based on the ingredient food groups and maximum calorie content.

Changes from Part 1
Delegate Notifiers: Added delegate notifiers to notify the user of the amount of calories the recipe contains.
Collections: Replaced arrays with generic collections, making storing ingredients and steps easier and more manageable.
Additional Classes and Functions: Added more classes and functions to accommodate new functionalities, such as storing recipes and their names, as well as food groups.
Unlimited Recipes: Users can store as many recipes as they want and can later choose the recipe they want to see, making the application more flexible and user-friendly.
How to Compile and Run the Program
Prerequisites
Ensure you have .NET Core SDK installed on your local machine.

Download or Clone Repository
Clone or download the repository from GitHub.

Open with Visual Studio 2022
Open the program using Visual Studio 2022 by opening the local folder where the repository is located.

Build and Run
Once the project is open in Visual Studio 2022, build the solution, and then run the program by clicking the run button at the top of the screen or by using the F5 key on your keyboard.

Usage
Adding a Recipe
Choose the "Add a new recipe" option.
Follow the prompts to input ingredients and steps for the recipe.
Save the recipe.
Displaying Recipes
Select the "Display recipe" option.
View the details of all saved recipes, including ingredients, steps, and total calories.
Apply filters for ingredients, food groups, and calorie limits if needed.
Scaling a Recipe
Use the "Scale recipe" option.
Choose the recipe to scale.
Select the scaling factor (2, 3, or 0.5).
View the updated ingredient quantities.
Deleting a Recipe
Choose the "Delete recipe" option.
Select the recipe to delete.
Confirm the deletion.
Clearing All Data
Select the "Clear all data" option.
Confirm to delete all recipes from the database.
Resetting Scale
Use the "Reset scale" option.
Choose the recipe to reset or reset all recipes.
Confirm to reset the scaled quantities back to their original values.
Code Overview
Adding a Recipe
The AddRecipePage class allows users to input and save recipes, including ingredients and steps. It handles user inputs, validates them, and stores them in generic collections for easier management.

Displaying Recipes
The DisplayRecipesPage class displays the list of recipes and their details. Users can filter recipes based on ingredients, food groups, and calorie content. The recipes are sorted alphabetically by default.

Scaling Recipes
The ScaleRecipesPage class enables users to scale the quantities of ingredients by factors of 2, 3, or 0.5. It also handles the conversion of units (e.g., teaspoons to tablespoons).

Deleting Recipes
The DeleteRecipesPage class provides functionality to delete individual recipes or all recipes from the database. It updates the user interface accordingly.

Resetting Scales
The ResetRecipesPage class allows users to reset the scaled quantities of ingredients back to their original values for selected or all recipes.

Main Window
The MainWindow class provides the main navigation interface, linking all the functionalities together.

Methods Class
The Methods class holds static lists of recipes, ingredients, and steps, facilitating the storage and retrieval of data across different parts of the application.

Calorie Notification
The application includes a delegate notifier that alerts users about the calorie content of recipes, helping them make informed dietary decisions.

License
This project is licensed under the MIT License.

For any further questions or issues, please refer to the GitHub repository or contact the project maintainer.

GitHub Repository