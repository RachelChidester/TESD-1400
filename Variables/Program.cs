// Swapping Variables

using System.Reflection.Metadata;
using System.Transactions;

int a = 0;
int b = 1;

Console.WriteLine($"{a} , {b}");

int temp = a;
a = b;
b = temp;

Console.WriteLine($"{a} , {b}");

// Information Formatting

string personName = "Scott";
string townName = "Kaysville";
int personAge = 28;

Console.WriteLine($"{personName} is from {townName} and is {personAge} years old.");

// Temperature Conversion
double celsius;


Console.WriteLine("Enter Temperature Here");
celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = celsius * 9 / 5 + 32;

Console.WriteLine($"{celsius} degrees Celsius is equivalent to {fahrenheit} degrees Farenheit");

// Area of a Rectangle

double width;
double height;
double perimeter;
double area;

Console.WriteLine("Enter Width Here");
width = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Height Here");
height = Convert.ToDouble(Console.ReadLine());

perimeter = width * 2 + height * 2;
area = width * height;

Console.WriteLine($"The rectangle is width {width} and height {height}. Its perimeter is {perimeter} and its area is {area}");

// Data Type Identification

int wholeNumbers = 25;
double decimalNumbers = 3.5;
char singleCharacter = 'a';
bool trueFalse = false;
string textData = "This is a sentence.";

Console.WriteLine($"{wholeNumbers.GetType()}: {wholeNumbers}");
Console.WriteLine($"{decimalNumbers.GetType()}: {decimalNumbers}");
Console.WriteLine($"{singleCharacter.GetType()}: {singleCharacter}");
Console.WriteLine($"{trueFalse.GetType()}: {trueFalse}");
Console.WriteLine($"{textData.GetType()}: {textData}");

