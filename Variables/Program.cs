// Swapping Variables

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


