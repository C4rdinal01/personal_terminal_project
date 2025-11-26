// See https://aka.ms/new-console-template for more information

//First we should initialize certain aspects: lets try making a simple inventory first!
List<string> inventory = new List<string>();

//Setting the base of all stats as 0 until predetermined by race attributes.
int playerHealth = 0;
int playerMana = 0;
int playerStrength = 0;
int playerSpeed = 0;

//Cant forget about currency!
int playerGold = 0;

//Onto the playable races
string[] races = new string[] { "Human", "Elf", "Dwarf", "Beastfolk" };

//These Boolians will make future route options much easier to maintain.
bool isHuman = false;
bool isElf = false;
bool isDwarf = false;
bool isBeastfolk = false;

//now we should add some encounter types.
string[] creatureType = new string[] { "Goblin", "Wolf", "Orc" };

//Now I need to make a baseline for Creature Stats
int creatureHP = 0;
int creatureMP = 0;
int creatureStrength = 0;
int creatureSpeed = 0;

/*
To Select one of the above possible creatures at random:

Console.ForegroundColor = ConsoleColor.Red;
Random rng = new Random();
int index = rng.Next(creatureType.Length);
string currentCreature = creatureType[index];

Console.WriteLine("A " + currentCreature + " has entered the battle!");
Console.ResetColor();
*/


//Here are the simple lines for repetitive stat and inventory displaying!
/*
For Stats:

Console.WriteLine("\nName: " + playerName +"\nRace: " + playerRace + "\n\n");
Console.WriteLine($"Hp: {playerHealth}\n\nMana: {playerMana}\n\nStrength: {playerStrength}\n\nSpeed: {playerSpeed}\n\n");

For Inventory:
foreach (string item in inventory)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(playerName + "'s Inventory:\n");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("- " + item + "\n");
    Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nGold: {playerGold}\n");
Console.ResetColor();
*/


// Now onto the starting code.

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Hello there, what is your name?\n\n");
Console.ResetColor();

String playerName = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n\nWell met " + playerName + "!\n\n");
Console.WriteLine("Now then, lets begin this adventure shall we?\n\nFirst, what race are you going to be?\n\n");
Console.WriteLine("The Races are as follows:\n\n");
Console.WriteLine("Human, Elf, Dwarf, and Beastfolk.\n\nPlease Choose your race now: \n");
Console.ResetColor();

string playerRace = Console.ReadLine();

if (playerRace == "Human" || playerRace == "human")
{
    isHuman = true;
    playerHealth = 80;
    playerMana = 20;
    playerStrength = 10;
    playerSpeed = 15;

    playerGold = 25;
}
else if (playerRace == "Elf" || playerRace == "elf")
{
    isElf = true;
    playerHealth = 60;
    playerMana = 50;
    playerStrength = 5;
    playerSpeed = 10;

    playerGold = 25;
}
else if (playerRace == "Dwarf" || playerRace == "dwarf")
{
    isDwarf = true;
    playerHealth = 100;
    playerMana = 10;
    playerStrength = 15;
    playerSpeed = 5;

    playerGold = 25;
}
else if (playerRace == "Beastfolk" || playerRace == "beastfolk")
{
    isBeastfolk = true;
    playerHealth = 80;
    playerMana = 10;
    playerStrength = 10;
    playerSpeed = 25;

    playerGold = 25;
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n\nVery well " + playerName + ", you have chosen the " + playerRace + " race.\n\n");
Console.WriteLine("These shall be your starting stats:\n");
Console.ResetColor();

//Time to write out the block for stats;
//Humans should be all rounders, Elves will be Magic Based, Dwarves will be Sturdy, and Beastfolk will be swift.

//This is the code for the inventory!
Console.WriteLine("\nName: " + playerName + "\nRace: " + playerRace + "\n\n");
Console.WriteLine($"Hp: {playerHealth}\n\nMana: {playerMana}\n\nStrength: {playerStrength}\n\nSpeed: {playerSpeed}\n\n");

//player can now choose one starting weapon.
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("You must now choose a starting weapon " + playerName + ".\n\n Your options are:\n\n1. Sword\n2. Dagger\n3. Hammer\n4. Staff\n\n");
Console.ResetColor();

string weaponChoice = Console.ReadLine();

switch (weaponChoice)
{
    case "1":
    case "sword":
    case "Sword":
        inventory.Add("Sword");
        Console.WriteLine("Sword added to your inventory!");
        break;

    case "2":
    case "dagger":
    case "Dagger":
        inventory.Add("Dagger");
        Console.WriteLine("Dagger added to your inventory!");
        break;

    case "3":
    case "hammer":
    case "Hammer":
        inventory.Add("Hammer");
        Console.WriteLine("Hammer added to your inventory!");
        break;

    case "4":
    case "staff":
    case "Staff":
        inventory.Add("Staff");
        Console.WriteLine("Staff added to your inventory!");
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n\nCongratulations on choosing your first weapon, the " + weaponChoice + ", " + playerName + "!\n");
Console.WriteLine("This is what your inventory looks like for your reference:\n\n");
Console.ResetColor();

//This is for displaying the inventory LIST in simplistic terms. Gold will be displayed at the bottom.
foreach (string item in inventory)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(playerName + "'s Inventory:\n");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("- " + item + "\n");
    Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nGold: {playerGold}\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n\nWonderful! Now that everything is out of the way, lets begin this battling adventure!\n\n\n");
Console.WriteLine("You are wandering through the woods on a bright early morning after having recieved word from the Guildmaster about some malicious beasts afoot.\n");
Console.WriteLine("Being the upstanding adventurer you are, you could never allow this filth to roam free and unchecked.\n");
Console.WriteLine("Hours pass by as you trek on and on until the monotony of your surroundings finally breaks at the sight of one such creature!\n");
Console.WriteLine("A foe has appeared before you! Time to battle, ready yourself " + playerName + "!\n\n");
Console.ResetColor();

//time for some battle coding!

Console.ForegroundColor = ConsoleColor.Red;
Random rng = new Random();
int index = rng.Next(creatureType.Length);
string currentCreature = creatureType[index];

Console.WriteLine("A " + currentCreature + " has entered the battle!");
Console.ResetColor();

if (currentCreature == "Wolf")
{
    creatureHP = 20;
    creatureMP = 10;
    creatureStrength = 15;
    creatureSpeed = 30;
    Console.ForegroundColor = ConsoleColor.Gray;
}
else if (currentCreature == "Orc")
{
    creatureHP = 40;
    creatureMP = 20;
    creatureStrength = 20;
    creatureSpeed = 15;
    Console.ForegroundColor = ConsoleColor.Yellow;
}
else if (currentCreature == "Goblin")
{
    creatureHP = 10;
    creatureMP = 5;
    creatureStrength = 10;
    creatureSpeed = 10;
    Console.ForegroundColor = ConsoleColor.Green;
}


Console.WriteLine($"\n{currentCreature}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\n\nHealth = {creatureHP}\nMana = {creatureMP}\nStrength =  {creatureStrength}\nSpeed = {creatureSpeed}");
Console.ResetColor();

//Now we need to make some 'movesets' for the player and monsters :D Yippie!
//Player First:

List<string> playerMoves = new List<string>();

if (weaponChoice == "Sword" || weaponChoice == "sword" || weaponChoice == "1")
{
    playerMoves.Add("Slash");
    playerMoves.Add("Stab");
    playerMoves.Add("Crippling Slash");
}
else if (weaponChoice == "Dagger" || weaponChoice == "dagger" || weaponChoice == "2")
{
    playerMoves.Add("Slash");
    playerMoves.Add("Stab");
    playerMoves.Add("Backstab");
}
else if (weaponChoice == "Staff" || weaponChoice == "staff" || weaponChoice == "4")
{
    playerMoves.Add("Smack");
    playerMoves.Add("Trip");
    playerMoves.Add("Cast Spell");
}
else if (weaponChoice == "Hammer" || weaponChoice == "hammer" || weaponChoice == "3")
{
    playerMoves.Add("Slam");
    playerMoves.Add("Sweeping Strike");
    playerMoves.Add("Crushing Blow");
}

//Monsters now:
List<string> goblinMoves = new List<string>();
List<string> orcMoves = new List<string>();
List<string> wolfMoves = new List<string>();

goblinMoves.Add("Claw Slash");
goblinMoves.Add("Bite Attack");
goblinMoves.Add("Dagger Attack");

orcMoves.Add("Punch Attack");
orcMoves.Add("Club Attack");
orcMoves.Add("Crushing Blow");

wolfMoves.Add("Bite Attack");
wolfMoves.Add("Claw Attack");
wolfMoves.Add("Maiming Bite");

//time to make an inititive calculator

bool PlayerGoesFirst = false;
bool CreatureGoesFirst = false;
Random rnd = new Random();

if (playerSpeed - creatureSpeed < 0)
{
    CreatureGoesFirst = true;
    PlayerGoesFirst = false;
}
else if (playerSpeed - creatureSpeed > 0)
{
    PlayerGoesFirst = true;
    CreatureGoesFirst = false;
}
else // equal speed
{
    int TieBreaker = rnd.Next(100); // 0–99

    if (TieBreaker >= 50)
    {
        PlayerGoesFirst = true;
    }
    else
    {
        CreatureGoesFirst = true;
    }
}

//now to impliment this inititive tracker.
Console.ForegroundColor = ConsoleColor.Cyan;
if (PlayerGoesFirst == true)
{
    Console.WriteLine($"\nYou've out paced the {currentCreature} and have the first chance to attack!\n");
}
else if (CreatureGoesFirst == true)
{
    Console.WriteLine($"\nThe {currentCreature} was faster this time and it takes the first move.\n");
}
Console.ResetColor();

// Now to make it so that the creature uses a random move from their Moveset, as well as set up the round based combat

// This is to ensure the currentCreature chosen doesnt accidentally access another Creatures' moveset.
List<string> currentCreatureMoves = null;

if (currentCreature == "Wolf")
{
    creatureHP = 20;
    creatureMP = 10;
    creatureStrength = 15;
    creatureSpeed = 30;
    Console.ForegroundColor = ConsoleColor.Gray;

    currentCreatureMoves = wolfMoves;
}
else if (currentCreature == "Orc")
{
    creatureHP = 40;
    creatureMP = 20;
    creatureStrength = 20;
    creatureSpeed = 15;
    Console.ForegroundColor = ConsoleColor.Yellow;

    currentCreatureMoves = orcMoves;
}
else if (currentCreature == "Goblin")
{
    creatureHP = 10;
    creatureMP = 5;
    creatureStrength = 10;
    creatureSpeed = 10;
    Console.ForegroundColor = ConsoleColor.Green;

    currentCreatureMoves = goblinMoves;
}

// these are the loops for combat

while (playerHealth > 0 && creatureHP > 0)
{
    if (PlayerGoesFirst)
    {
        // Player turn here
        // ...

        if (creatureHP <= 0) break;

        int moveIndex = rnd.Next(currentCreatureMoves.Count);
        string chosenMove = currentCreatureMoves[moveIndex];
        Console.WriteLine($"\nThe {currentCreature} uses {chosenMove}!");
        // apply damage here
    }
    else
    {
        int moveIndex = rnd.Next(currentCreatureMoves.Count);
        string chosenMove = currentCreatureMoves[moveIndex];
        Console.WriteLine($"\nThe {currentCreature} uses {chosenMove}!");
        // apply damage here

        if (playerHealth <= 0) break;

        // Player turn here
    }
}