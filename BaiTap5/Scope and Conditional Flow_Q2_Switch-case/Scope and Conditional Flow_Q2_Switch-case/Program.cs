//---------------------------------------------------------------------
// Question 1: Basic Switch Case
// Write a C# program that prompts the user to enter a number between 1 and 3. Using a switch-case statement,
// display a message based on the number entered. If the number is 1, print "One"; if the number is 2, print "Two"; if the number is 3, print "Three".
// If the number does not match any of these, display a default message.
// Hint: Use Console.ReadLine() to get user input and Convert.ToInt32() to convert the input to an integer.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-3): ");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            default:
                Console.WriteLine("Invalid number");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 2: Game Character Selection
// In a game, the player can select a character class using numbers 1 to 3.
// Write a C# program that prompts the player to choose a character class.
// Based on the chosen number, display a message indicating the selected class: 1 for Warrior, 2 for Mage, and 3 for Archer.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different cases of character selection.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Choose your character (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Warrior");
                break;
            case 2:
                Console.WriteLine("You selected Mage");
                break;
            case 3:
                Console.WriteLine("You selected Archer");
                break;
            default:
                Console.WriteLine("Invalid selection!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 3: Directional Movement
// In a game, the player can move in four cardinal directions: North, South, East, and West.
// Write a C# program that prompts the player to enter a direction using numbers 1 to 4.
// Based on the chosen number, display a message indicating the direction: 1 for North, 2 for South, 3 for East, and 4 for West.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different directional inputs.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter direction (1-4): ");
        int direction = Convert.ToInt32(Console.ReadLine());

        switch (direction)
        {
            case 1:
                Console.WriteLine("Moving North ↑");
                break;
            case 2:
                Console.WriteLine("Moving South ↓");
                break;
            case 3:
                Console.WriteLine("Moving East →");
                break;
            case 4:
                Console.WriteLine("Moving West ←");
                break;
            default:
                Console.WriteLine("Invalid direction!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 4: Day of the Week
// Write a C# program that prompts the user to enter a number between 1 and 7 representing a day of the week.
// Use a switch-case statement to display the name of the corresponding day.
// For example, if the user enters 1, print "Monday"; if 2, print "Tuesday", and so on. If the number does not match any of these, display a default message.
// Hint: Map each number input to a specific day of the week using a switch-case statement.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 5: Weapon Selection
// In a game, the player can select a weapon using numbers 1 to 4.
// Write a C# program that prompts the player to choose a weapon. Based on the chosen number, display a message indicating the selected weapon: 1 for Sword, 2 for Bow, 3 for Staff, and 4 for Axe.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different weapon choices.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Choose your weapon (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Sword");
                break;
            case 2:
                Console.WriteLine("You selected Bow");
                break;
            case 3:
                Console.WriteLine("You selected Staff");
                break;
            case 4:
                Console.WriteLine("You selected Axe");
                break;
            default:
                Console.WriteLine("Invalid selection!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 6: Elemental Magic
// In a fantasy game, the player can cast elemental magic spells using numbers 1 to 5.
// Write a C# program that prompts the player to select a magic spell. Based on the chosen number, display a message indicating the selected spell element: 1 for Fire, 2 for Water, 3 for Earth, 4 for Air, and 5 for Lightning.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different spell selections.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Choose your spell (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You cast Fire");
                break;
            case 2:
                Console.WriteLine("You cast Water");
                break;
            case 3:
                Console.WriteLine("You cast Earth");
                break;
            case 4:
                Console.WriteLine("You cast Air");
                break;
            case 5:
                Console.WriteLine("You cast Lightning");
                break;
            default:
                Console.WriteLine("Invalid spell selection!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 7: Menu Navigation
// Write a C# program that simulates a menu navigation system for a game.
// The user can enter numbers 1 to 4 to navigate through different menu options: 1 for Start Game, 2 for Options, 3 for Load Game, and 4 for Exit.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle user input and navigate between menu options.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== GAME MENU ===");
        Console.WriteLine("1. Start Game");
        Console.WriteLine("2. Options");
        Console.WriteLine("3. Load Game");
        Console.WriteLine("4. Exit");

        Console.Write("Choose an option (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Starting game...");
                break;
            case 2:
                Console.WriteLine("Opening options...");
                break;
            case 3:
                Console.WriteLine("Loading game...");
                break;
            case 4:
                Console.WriteLine("Exiting game...");
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 8: NPC Interaction
// In an RPG game, the player can interact with non-player characters (NPCs) using numbers 1 to 3.
// Write a C# program that prompts the player to choose an interaction option with an NPC. Based on the chosen number, display a message indicating the selected interaction: 1 for Talk, 2 for Trade, and 3 for Quest.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different interaction options with NPCs.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== NPC Interaction ===");
        Console.WriteLine("1. Talk");
        Console.WriteLine("2. Trade");
        Console.WriteLine("3. Quest");

        Console.Write("Choose an option (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You start a conversation");
                break;
            case 2:
                Console.WriteLine("Opening trade menu");
                break;
            case 3:
                Console.WriteLine("Viewing available quests");
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 9: Puzzle Solutions
// In a puzzle-solving game, the player can choose from different solutions using numbers 1 to 5.
// Write a C# program that prompts the player to select a solution for a puzzle. Based on the chosen number, display a message indicating the selected solution option.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different puzzle solution choices.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Puzzle Solutions ===");
        Console.WriteLine("1. Solution A");
        Console.WriteLine("2. Solution B");
        Console.WriteLine("3. Solution C");
        Console.WriteLine("4. Solution D");
        Console.WriteLine("5. Solution E");

        Console.Write("Choose a solution (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Solution A");
                break;
            case 2:
                Console.WriteLine("You selected Solution B");
                break;
            case 3:
                Console.WriteLine("You selected Solution C");
                break;
            case 4:
                Console.WriteLine("You selected Solution D");
                break;
            case 5:
                Console.WriteLine("You selected Solution E");
                break;
            default:
                Console.WriteLine("Invalid solution!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 10: Dialogue Choices
// Write a C# program that simulates dialogue choices in a game. The player can select dialogue options using numbers 1 to 4.
// Based on the chosen number, display a message indicating the selected dialogue choice. If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different dialogue options presented to the player.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Dialogue Choices ===");
        Console.WriteLine("1. Hello!");
        Console.WriteLine("2. Who are you?");
        Console.WriteLine("3. Any quests?");
        Console.WriteLine("4. Goodbye.");

        Console.Write("Choose an option (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You said: Hello!");
                break;
            case 2:
                Console.WriteLine("You said: Who are you?");
                break;
            case 3:
                Console.WriteLine("You said: Any quests?");
                break;
            case 4:
                Console.WriteLine("You said: Goodbye.");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 11: Crafting Items
// In a crafting system, the player can select crafting recipes using numbers 1 to 3.
// Write a C# program that prompts the player to choose a crafting recipe.
// Based on the chosen number, display a message indicating the selected recipe: 1 for Potion, 2 for Weapon, and 3 for Armor. If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different crafting recipe selections.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Crafting System ===");
        Console.WriteLine("1. Potion");
        Console.WriteLine("2. Weapon");
        Console.WriteLine("3. Armor");

        Console.Write("Choose a recipe (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You crafted a Potion");
                break;
            case 2:
                Console.WriteLine("You crafted a Weapon");
                break;
            case 3:
                Console.WriteLine("You crafted an Armor");
                break;
            default:
                Console.WriteLine("Invalid recipe!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 12: Scene Selection
// Write a C# program that simulates scene selection in a game.
// The player can choose scenes using numbers 1 to 5. Based on the chosen number, display a message indicating the selected scene.
// If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different scene selections.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Scene Selection ===");
        Console.WriteLine("1. Main Menu");
        Console.WriteLine("2. Forest");
        Console.WriteLine("3. Dungeon");
        Console.WriteLine("4. Castle");
        Console.WriteLine("5. Battle Arena");

        Console.Write("Choose a scene (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Loading Main Menu...");
                break;
            case 2:
                Console.WriteLine("Entering the Forest");
                break;
            case 3:
                Console.WriteLine("Entering the Dungeon");
                break;
            case 4:
                Console.WriteLine("Entering the Castle");
                break;
            case 5:
                Console.WriteLine("Entering the Battle Arena");
                break;
            default:
                Console.WriteLine("Invalid scene!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 13: Quest Progression
// In an adventure game, the player can progress through quests using numbers 1 to 4.
// Write a C# program that prompts the player to select a quest. Based on the chosen number, display a message indicating the selected quest.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different quest selections and progression

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Quest Progression ===");
        Console.WriteLine("1. Find the Lost Sword");
        Console.WriteLine("2. Rescue the Villagers");
        Console.WriteLine("3. Defeat the Dragon");
        Console.WriteLine("4. Explore the Ancient Ruins");

        Console.Write("Choose a quest (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Quest started: Find the Lost Sword");
                break;
            case 2:
                Console.WriteLine("Quest started: Rescue the Villagers");
                break;
            case 3:
                Console.WriteLine("Quest started: Defeat the Dragon");
                break;
            case 4:
                Console.WriteLine("Quest started: Explore the Ancient Ruins");
                break;
            default:
                Console.WriteLine("Invalid quest!");
                break;
        }
    }
}*/


//---------------------------------------------------------------------
// Question 14: Potion Brewing
// In an alchemy system, the player can brew potions using numbers 1 to 3.
// Write a C# program that prompts the player to choose a potion to brew. Based on the chosen number, display a message indicating the selected potion: 1 for Health Potion, 2 for Mana Potion, and 3 for Stamina Potion.
// If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different potion brewing choices.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Potion Brewing ===");
        Console.WriteLine("1. Health Potion");
        Console.WriteLine("2. Mana Potion");
        Console.WriteLine("3. Stamina Potion");

        Console.Write("Choose a potion (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You brewed a Health Potion");
                break;
            case 2:
                Console.WriteLine("You brewed a Mana Potion");
                break;
            case 3:
                Console.WriteLine("You brewed a Stamina Potion");
                break;
            default:
                Console.WriteLine("Invalid potion!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 15: Platform Movement
// In a platformer game, the player can move the character using numbers 1 to 4 for directional controls.
// Write a C# program that prompts the player to enter a movement direction. Based on the chosen number, display a message indicating the movement direction: 1 for Left, 2 for Right, 3 for Jump, and 4 for Crouch.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different movement directions, including a default case.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Platform Movement ===");
        Console.WriteLine("1. Left");
        Console.WriteLine("2. Right");
        Console.WriteLine("3. Jump");
        Console.WriteLine("4. Crouch");

        Console.Write("Choose movement (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Moving Left ←");
                break;
            case 2:
                Console.WriteLine("Moving Right →");
                break;
            case 3:
                Console.WriteLine("Jumping ⬆️");
                break;
            case 4:
                Console.WriteLine("Crouching ⬇️");
                break;
            default:
                Console.WriteLine("Invalid movement!");
                break;
        }
    }
}*/


//////////////////////Break Statements//////////////////////

//---------------------------------------------------------------------
// Question 16: Weapon Upgrades
// In a game, the player can upgrade their weapon using different materials.
// Write a C# program that prompts the player to choose a material for weapon upgrade.
// Based on the chosen number, display a message indicating the selected material. Use a switch-case statement to handle the different material choices: 1 for Iron, 2 for Steel, 3 for Gold, and 4 for Diamond.
// After displaying the selected material, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different material choices and use break statements to exit the switch-case block.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Weapon Upgrade ===");
        Console.WriteLine("1. Iron");
        Console.WriteLine("2. Steel");
        Console.WriteLine("3. Gold");
        Console.WriteLine("4. Diamond");

        Console.Write("Choose material (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Weapon upgraded with Iron");
                break;
            case 2:
                Console.WriteLine("Weapon upgraded with Steel");
                break;
            case 3:
                Console.WriteLine("Weapon upgraded with Gold");
                break;
            case 4:
                Console.WriteLine("Weapon upgraded with Diamond");
                break;
            default:
                Console.WriteLine("Invalid material!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 17: Spell Casting
// In a fantasy game, the player can cast spells using different magic elements.
// Write a C# program that prompts the player to select a spell element. Based on the chosen number, display a message indicating the selected spell element: 1 for Fire, 2 for Water, 3 for Earth, and 4 for Air.
// After displaying the selected element, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different spell elements and use break statements to exit the switch-case block.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Spell Casting ===");
        Console.WriteLine("1. Fire");
        Console.WriteLine("2. Water");
        Console.WriteLine("3. Earth");
        Console.WriteLine("4. Air");

        Console.Write("Choose a spell (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You cast Fire");
                break;
            case 2:
                Console.WriteLine("You cast Water");
                break;
            case 3:
                Console.WriteLine("You cast Earth");
                break;
            case 4:
                Console.WriteLine("You cast Air");
                break;
            default:
                Console.WriteLine("Invalid spell!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 18: Skill Selection
// In a role-playing game (RPG), the player can choose skills to improve their character's abilities.
// Write a C# program that prompts the player to select a skill for enhancement. Based on the chosen number, display a message indicating the selected skill: 1 for Strength, 2 for Agility, 3 for Intelligence, and 4 for Vitality.
// After displaying the selected skill, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different skill selections and use break statements to exit the switch-case block.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Skill Selection ===");
        Console.WriteLine("1. Strength");
        Console.WriteLine("2. Agility");
        Console.WriteLine("3. Intelligence");
        Console.WriteLine("4. Vitality");

        Console.Write("Choose a skill (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Strength");
                break;
            case 2:
                Console.WriteLine("You selected Agility");
                break;
            case 3:
                Console.WriteLine("You selected Intelligence");
                break;
            case 4:
                Console.WriteLine("You selected Vitality");
                break;
            default:
                Console.WriteLine("Invalid skill!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 19: Puzzle Solutions
// In a puzzle-solving game, the player can choose from different solutions to progress through the game.
// Write a C# program that prompts the player to select a solution for a puzzle. Based on the chosen number, display a message indicating the selected solution option.
// After displaying the selected solution, include a break statement to terminate the switch-case block.
// Hint: Use switch-case statements to handle different puzzle solution choices and use break statements to exit the switch-case block.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Puzzle Solutions ===");
        Console.WriteLine("1. Pull the lever");
        Console.WriteLine("2. Press the button");
        Console.WriteLine("3. Turn the key");
        Console.WriteLine("4. Open the door");

        Console.Write("Choose a solution (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You pulled the lever");
                break;
            case 2:
                Console.WriteLine("You pressed the button");
                break;
            case 3:
                Console.WriteLine("You turned the key");
                break;
            case 4:
                Console.WriteLine("You opened the door");
                break;
            default:
                Console.WriteLine("Invalid solution!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 20: Potion Brewing
// In an alchemy system, the player can brew potions using different ingredients.
// Write a C# program that prompts the player to choose an ingredient for potion brewing. Based on the chosen number, display a message indicating the selected ingredient: 1 for Herb, 2 for Mushroom, 3 for Flower, and 4 for Crystal.
// After displaying the selected ingredient, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different ingredient choices and use break statements to exit the switch-case block.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Potion Brewing (Ingredients) ===");
        Console.WriteLine("1. Herb");
        Console.WriteLine("2. Mushroom");
        Console.WriteLine("3. Flower");
        Console.WriteLine("4. Crystal");

        Console.Write("Choose an ingredient (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Herb");
                break;
            case 2:
                Console.WriteLine("You selected Mushroom");
                break;
            case 3:
                Console.WriteLine("You selected Flower");
                break;
            case 4:
                Console.WriteLine("You selected Crystal");
                break;
            default:
                Console.WriteLine("Invalid ingredient!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 21: NPC Interactions
// In a game world, the player can interact with non-player characters (NPCs) in various ways.
// Write a C# program that simulates NPC interactions based on player input. Prompt the player to choose an interaction option with an NPC using numbers 1 to 3: 1 for Talk, 2 for Trade, and 3 for Quest.
// After displaying the selected interaction, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different NPC interaction options and use break statements to exit the switch-case block.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== NPC Interaction ===");
        Console.WriteLine("1. Talk");
        Console.WriteLine("2. Trade");
        Console.WriteLine("3. Quest");

        Console.Write("Choose an option (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You start talking to the NPC");
                break;
            case 2:
                Console.WriteLine("You open the trade menu");
                break;
            case 3:
                Console.WriteLine("You receive a quest");
                break;
            default:
                Console.WriteLine("Invalid interaction!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 22: Scene Navigation
// Write a C# program that simulates scene navigation in a game.
// The player can choose scenes using numbers 1 to 5 to navigate through different game environments.
// After displaying the selected scene, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different scene selections and use break statements to exit the switch-case block.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Scene Navigation ===");
        Console.WriteLine("1. Main Menu");
        Console.WriteLine("2. Forest");
        Console.WriteLine("3. Dungeon");
        Console.WriteLine("4. Castle");
        Console.WriteLine("5. Arena");

        Console.Write("Choose a scene (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Loading Main Menu...");
                break;
            case 2:
                Console.WriteLine("Entering Forest 🌲");
                break;
            case 3:
                Console.WriteLine("Entering Dungeon 🕳️");
                break;
            case 4:
                Console.WriteLine("Entering Castle 🏰");
                break;
            case 5:
                Console.WriteLine("Entering Arena ⚔️");
                break;
            default:
                Console.WriteLine("Invalid scene!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 23: Quest Progression
// In an adventure game, the player can progress through quests using different options.
// Write a C# program that prompts the player to select a quest option. After displaying the selected quest option, include a break statement to terminate the switch-case block.
// Hint: Use switch-case statements to handle different quest options and use break statements to exit the switch-case block.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Quest Progression ===");
        Console.WriteLine("1. Accept Quest");
        Console.WriteLine("2. View Quest Details");
        Console.WriteLine("3. Complete Quest");
        Console.WriteLine("4. Claim Reward");

        Console.Write("Choose an option (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Quest accepted");
                break;
            case 2:
                Console.WriteLine("Viewing quest details");
                break;
            case 3:
                Console.WriteLine("Quest completed");
                break;
            case 4:
                Console.WriteLine("Reward claimed");
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }
}*/

//---------------------------------------------------------------------
// Question 24: Menu Navigation
// Write a C# program that simulates menu navigation in a game.
// The player can navigate through menu options using numbers 1 to 4: 1 for Start, 2 for Options, 3 for Load Game, and 4 for Exit.
// After displaying the selected menu option, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different menu options and use break statements to exit the switch-case block.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Game Menu ===");
        Console.WriteLine("1. Start");
        Console.WriteLine("2. Options");
        Console.WriteLine("3. Load Game");
        Console.WriteLine("4. Exit");

        Console.Write("Choose an option (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Starting game...");
                break;
            case 2:
                Console.WriteLine("Opening settings...");
                break;
            case 3:
                Console.WriteLine("Loading game...");
                break;
            case 4:
                Console.WriteLine("Exiting game...");
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }
}