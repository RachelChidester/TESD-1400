
List<int> year;
List<string> make;
List<string> model;

 year = new List<int>();
 make = new List<string>();
 model = new List<string>();


writeText();

int userInput = GetUserInput();

Console.WriteLine($"Your selection: {userInput}");
static void writeText()
{
    Console.WriteLine("What would you like to do? Choose one: 1: View Inventory. 2: Add Vehichle. 3: Remove Vehichle. 4: Quit.");
}

static int GetUserInput()
{
    string input = Console.ReadLine();
    if (int.TryParse(input, out int result))
    {
        return result;
    }
    Console.WriteLine("Invalid entry. Please enter a number.");
    return 0; 
}









// Make Console.WriteLine statements, when 1 is enetered, when 2 is entered, etc, use 'while loop'? for like until user hits quit?

//when 1 is enetered, when 2 is entered, etc, is a else/ else if, right?



// Make a 2D OR parallel array OR list
// Create functions
// Create main interaction loop (loop condidtion is whether user selected 'quit' option)
// To do that, would I nest a if/elseif loop in a while loop?
