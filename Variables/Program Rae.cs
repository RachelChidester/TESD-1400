// // Swapping Variables

// using System.Reflection.Metadata;
// using System.Transactions;

// int a = 0;
// int b = 1;

// Console.WriteLine($"{a} , {b}");

// int temp = a;
// a = b;
// b = temp;

// Console.WriteLine($"{a} , {b}");

// // Information Formatting

// string personName = "Scott";
// string townName = "Kaysville";
// int personAge = 28;

// Console.WriteLine($"{personName} is from {townName} and is {personAge} years old.");

// // Temperature Conversion
// double celsius;


// Console.WriteLine("Enter Temperature Here");
// celsius = Convert.ToDouble(Console.ReadLine());

// double fahrenheit = celsius * 9 / 5 + 32;

// Console.WriteLine($"{celsius} degrees Celsius is equivalent to {fahrenheit} degrees Farenheit");

// // Area of a Rectangle

// double width;
// double height;
// double perimeter;
// double area;

// Console.WriteLine("Enter Width Here");
// width = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter Height Here");
// height = Convert.ToDouble(Console.ReadLine());

// perimeter = width * 2 + height * 2;
// area = width * height;

// Console.WriteLine($"The rectangle is width {width} and height {height}. Its perimeter is {perimeter} and its area is {area}");

// // Data Type Identification

// int wholeNumbers = 25;
// double decimalNumbers = 3.5;
// char singleCharacter = 'a';
// bool trueFalse = false;
// string textData = "This is a sentence.";

// Console.WriteLine($"{wholeNumbers.GetType()}: {wholeNumbers}");
// Console.WriteLine($"{decimalNumbers.GetType()}: {decimalNumbers}");
// Console.WriteLine($"{singleCharacter.GetType()}: {singleCharacter}");
// Console.WriteLine($"{trueFalse.GetType()}: {trueFalse}");
// Console.WriteLine($"{textData.GetType()}: {textData}");

// Positive, Negative, or Zero


Console.WriteLine("Enter Number Here");
string input = Console.ReadLine();

if (int.TryParse(input, out int number));
{
    if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {number} is neither positive or negative, it is zero.");
    }
}

// Number Conparison

Console.WriteLine("Enter a number");
input = Console.ReadLine();
if (int.TryParse(input, out int number1));

Console.WriteLine("Enter another number");
input = Console.ReadLine();
if (int.TryParse(input, out int number2));
{
    if (number1 > number2)
    {
        Console.WriteLine("Number 1 is greater");
    }
    else if (number1 < number2)
    {
        Console.WriteLine("Number 2 is greater");
    }
    else
    {
        Console.WriteLine("The numbers are the same.");
    }
}

// Letter Grade Calculator

Console.WriteLine("Enter 0-100");
input = Console.ReadLine();
string letterGrade ="";
if (int.TryParse(input, out int grade))
{
    if (grade < 60)
    {
      letterGrade = "F";
    }
    else if (grade < 70)
    {
      letterGrade = "D"; 
    }
    else if (grade < 80)
    {
        letterGrade = "C";
    }
    else if (grade < 90)
    {
        letterGrade = "B";
    }
    else
    {
        letterGrade = "A";
    }
}

Console.WriteLine($"A score of {grade} represents a letter grade of {letterGrade}");

// Day of the Week

Console.WriteLine("Enter a number 1-7");
input = Console.ReadLine();
int.TryParse(input, out int dayOfTheWeek);
string dayOfWeek ="";

switch (dayOfTheWeek)
{
    case 1:
        dayOfWeek = "Monday";
        break;
    case 2:
        dayOfWeek = "Tuesday";
        break;
    case 3:
        dayOfWeek = "Wednesday";
        break;
    case 4:
        dayOfWeek = "Thursday";
        break;
    case 5:
        dayOfWeek = "Friday";
        break;
    case 6:
        dayOfWeek = "Saturday";
        break;
    case 7:
        dayOfWeek = "Sunday";
        break;
}
Console.WriteLine($"Today is {dayOfWeek}");

//Discount Calculation

Console.WriteLine("Enter Purchase Amount Here");
input = Console.ReadLine();
if (int.TryParse(input, out int purchase));
{
    double finalPurchase;
    if (purchase > 100)
    {
        finalPurchase = purchase * 0.90;
    }
    else
    {
        finalPurchase = purchase;
    }
    Console.WriteLine($"Final Purchase Amount: ${finalPurchase}");
}

