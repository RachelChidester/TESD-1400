




//Excersices: Functions


//Check Even or Odd
bool IsEven(int number)
{
    return number % 2 == 0;
}

Console.WriteLine("Enter a number");
string input = Console.ReadLine();
if (int.TryParse(input, out int userNumber))
{
    bool result = IsEven(userNumber);
    if (result)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}

// Array Functions

int SumArray(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}

double AverageArray(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        return 0.0;
    }
    double total = SumArray(numbers);
    return total / numbers.Length;
}


// Prompt for Integer

int PromptInt(string message)
{
    while (true)
    {
        Console.WriteLine("Please enter a valid integer value");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
           Console.WriteLine("Please enter a valid integer value"); 
        } 
    }
}

// Factorial

int Factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }

    return n * Factorial(n - 1);
}




// // Number Guessing Game

// Random rand = new Random();
// int randomNumber = rand.Next(20) + 1;
// int guess = 0;

// while (true){
// Console.WriteLine("Pick a number between 1 and 20");
// string input = Console.ReadLine();
// if (int.TryParse(input, out int result)){
//     guess += 1;
//    if (result > randomNumber)
//     {
//         Console.WriteLine("Too high! Try guessing lower");
//     }
//     else if (result < randomNumber)
//     {
//         Console.WriteLine("Too low! Try guessing higher!");
//     }
//     else if (result == randomNumber)
//     {
//         Console.WriteLine($"Correct! The value was {randomNumber}. It took you {guess} guesses.");
//         break;

//     }
// }
//     else
//     {
//         Console.WriteLine("Invalid. Try again");
//     }

// }









// // // Swapping Variables

// // using System.Reflection.Metadata;
// // using System.Transactions;

// // int a = 0;
// // int b = 1;

// // Console.WriteLine($"{a} , {b}");

// // int temp = a;
// // a = b;
// // b = temp;

// // Console.WriteLine($"{a} , {b}");

// // // Information Formatting

// // string personName = "Scott";
// // string townName = "Kaysville";
// // int personAge = 28;

// // Console.WriteLine($"{personName} is from {townName} and is {personAge} years old.");

// // // Temperature Conversion
// // double celsius;


// // Console.WriteLine("Enter Temperature Here");
// // celsius = Convert.ToDouble(Console.ReadLine());

// // double fahrenheit = celsius * 9 / 5 + 32;

// // Console.WriteLine($"{celsius} degrees Celsius is equivalent to {fahrenheit} degrees Farenheit");

// // // Area of a Rectangle

// // double width;
// // double height;
// // double perimeter;
// // double area;

// // Console.WriteLine("Enter Width Here");
// // width = Convert.ToDouble(Console.ReadLine());

// // Console.WriteLine("Enter Height Here");
// // height = Convert.ToDouble(Console.ReadLine());

// // perimeter = width * 2 + height * 2;
// // area = width * height;

// // Console.WriteLine($"The rectangle is width {width} and height {height}. Its perimeter is {perimeter} and its area is {area}");

// // // Data Type Identification

// // int wholeNumbers = 25;
// // double decimalNumbers = 3.5;
// // char singleCharacter = 'a';
// // bool trueFalse = false;
// // string textData = "This is a sentence.";

// // Console.WriteLine($"{wholeNumbers.GetType()}: {wholeNumbers}");
// // Console.WriteLine($"{decimalNumbers.GetType()}: {decimalNumbers}");
// // Console.WriteLine($"{singleCharacter.GetType()}: {singleCharacter}");
// // Console.WriteLine($"{trueFalse.GetType()}: {trueFalse}");
// // Console.WriteLine($"{textData.GetType()}: {textData}");

// // Positive, Negative, or Zero


// // Console.WriteLine("Enter Number Here");
// // string input = Console.ReadLine();

// // if (int.TryParse(input, out int number));
// // {
// //     if (number > 0)
// //     {
// //         Console.WriteLine($"The number {number} is positive.");
// //     }
// //     else if (number < 0)
// //     {
// //         Console.WriteLine($"The number {number} is negative.");
// //     }
// //     else
// //     {
// //         Console.WriteLine($"The number {number} is neither positive or negative, it is zero.");
// //     }
// // }

// // // Number Conparison

// // Console.WriteLine("Enter a number");
// // input = Console.ReadLine();
// // if (int.TryParse(input, out int number1));

// // Console.WriteLine("Enter another number");
// // input = Console.ReadLine();
// // if (int.TryParse(input, out int number2));
// // {
// //     if (number1 > number2)
// //     {
// //         Console.WriteLine("Number 1 is greater");
// //     }
// //     else if (number1 < number2)
// //     {
// //         Console.WriteLine("Number 2 is greater");
// //     }
// //     else
// //     {
// //         Console.WriteLine("The numbers are the same.");
// //     }
// // }

// // // Letter Grade Calculator

// // Console.WriteLine("Enter 0-100");
// // input = Console.ReadLine();
// // string letterGrade ="";
// // if (int.TryParse(input, out int grade))
// // {
// //     if (grade < 60)
// //     {
// //       letterGrade = "F";
// //     }
// //     else if (grade < 70)
// //     {
// //       letterGrade = "D"; 
// //     }
// //     else if (grade < 80)
// //     {
// //         letterGrade = "C";
// //     }
// //     else if (grade < 90)
// //     {
// //         letterGrade = "B";
// //     }
// //     else
// //     {
// //         letterGrade = "A";
// //     }
// // }

// // Console.WriteLine($"A score of {grade} represents a letter grade of {letterGrade}");

// // // Day of the Week

// // Console.WriteLine("Enter a number 1-7");
// // input = Console.ReadLine();
// // int.TryParse(input, out int dayOfTheWeek);
// // string dayOfWeek ="";

// // switch (dayOfTheWeek)
// // {
// //     case 1:
// //         dayOfWeek = "Monday";
// //         break;
// //     case 2:
// //         dayOfWeek = "Tuesday";
// //         break;
// //     case 3:
// //         dayOfWeek = "Wednesday";
// //         break;
// //     case 4:
// //         dayOfWeek = "Thursday";
// //         break;
// //     case 5:
// //         dayOfWeek = "Friday";
// //         break;
// //     case 6:
// //         dayOfWeek = "Saturday";
// //         break;
// //     case 7:
// //         dayOfWeek = "Sunday";
// //         break;
// // }
// // Console.WriteLine($"Today is {dayOfWeek}");

// // //Discount Calculation

// // Console.WriteLine("Enter Purchase Amount Here");
// // input = Console.ReadLine();
// // if (int.TryParse(input, out int purchase));
// // {
// //     double finalPurchase;
// //     if (purchase > 100)
// //     {
// //         finalPurchase = purchase * 0.90;
// //     }
// //     else
// //     {
// //         finalPurchase = purchase;
// //     }
// //     Console.WriteLine($"Final Purchase Amount: ${finalPurchase}");
// // }


// // Seating Arrangement

// using System.Runtime.CompilerServices;
// using System.Security.Claims;
// using System.Transactions;

// Console.WriteLine("Theater Seating Arrangement");
// string seatsInRow = "";
// for (int rows = 1; rows <= 5; rows++)
// { 
//     for (int seatNumber = 1; seatNumber <= 10; seatNumber++)
//     {
//         seatsInRow += $"{rows}-{seatNumber} ";
//     }
// }

// Console.WriteLine($"{seatsInRow}");


// // Simple interest Calculator

// Console.WriteLine("Simple Interest Calculation");

// double principal = 1000;
// int rate = 5;
// int years = 1;

// while (years <= 5)
// {
//     double interest = (principal * rate * years) / 100;
//     Console.WriteLine($"Year {years}: ${interest}");

//     years++;
// }

// // Prime Numbers

// Console.WriteLine("Prime Numbers between 2 and 30:");

// for (int num = 2; num <= 30; num++)
// {
//     bool isPrime = true;
//     for (int devide = 2; devide <= num / 2; devide++)
//     {
//         if (num % devide == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }

//     if (isPrime)
//     {
//         Console.WriteLine($"{num}");
//     }
// }


// // Print Numbers in Reverse Order

// Console.WriteLine("Numbers from 20 to 1");

// for (int i = 20; i > 0; i--)
// {
//     Console.WriteLine($"{i}");
// }


// // Simple Login

// Console.WriteLine("Enter Username");
// string username = Console.ReadLine();

// Console.WriteLine("Enter Password");
// string password = Console.ReadLine();

// while (username != "awesome_user_42" || password != "p455w0rd")
// {
//     Console.WriteLine("Sorry, you have entered an incorrect username or password");
//     Console.WriteLine("Enter Username");
//     username = Console.ReadLine();
//     Console.WriteLine("Enter Password");
//     password = Console.ReadLine();
// }

// Console.WriteLine("Successfully logged in! Welcome!");


// //Iterare Over an Array

// string[] someStrings = ["This", "is", "an", "array", "of", "strings", "let's", "iterate", "over", "it!"];

// foreach (string word in someStrings)
// {
//     Console.WriteLine($"{word} ");
// }


// Excercise: Arrays and Lists

//Simple Array Operations


// using System.Data;

// int[] valuesah = {1, 2, 3, 4, 5};

// for (int i = 0; i < valuesah.Length; i++)
// {
//     Console.WriteLine($"{valuesah[i]}");
// }


// // Sum of Elements

// int[] value = new int[5];
// int finalValue = 0; 

// for (int i = 0; i < value.Length; i++)
// {
//     Console.WriteLine($"Input a value");
//     value[i] = int.Parse(Console.ReadLine());
// }
// foreach (int val in value)
// {
//     finalValue += val;
// }
// Console.WriteLine($" Final sum: {finalValue}");


// //List of Strings

// List<string> names = new List<string>();

// for (int i= 0; i < 5; i++)
// {
//     Console.WriteLine($"Enter a Name");
//     string input = Console.ReadLine();
//     names.Add(input);
// }
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }


// // Sorting a List

// List<string> words = new List<string>();
// List<int> numbers = new List<int>();

// words.Add("This");
// words.Add("is");
// words.Add("going");
// words.Add("to");
// words.Add("work");

// numbers.Add(5);
// numbers.Add(40);
// numbers.Add(15);
// numbers.Add(3255);
// numbers.Add(25);

// foreach (string word in words)
// {
//     Console.WriteLine(word);
// }
// foreach (int num in numbers)
// {
//     Console.WriteLine(num);
// }

// words.Sort();
// numbers.Sort();

// foreach (string word in words)
// {
//     Console.WriteLine(word);
// }
// foreach (int num in numbers)
// {
//     Console.WriteLine(num);
// }


// // Running Total

// var values = new List<int>();
// var runningTotal = new List<int>();

// for (int i= 0; i < 5; i++)
// {
//     Console.WriteLine("Input a value");
//     values.Add(int.Parse(Console.ReadLine()));
//     if (i != 0)
//     {
//         runningTotal.Add(runningTotal[i-1] + values[i]);
//     }
//     else
//     {
//         runningTotal.Add(values[i]);
//     }
// }

// for (int i = 0; i <values.Count(); i++)
// {
//     Console.WriteLine($"Value: {values[i]}, Running Total: {runningTotal[i]}");
// }

