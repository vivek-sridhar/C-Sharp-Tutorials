using System.ComponentModel;

Console.WriteLine("Hello!");
Console.Write("Input the first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Input the second number: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd: " + number1 + " + " + number2);
Console.WriteLine("[S]ubtract: " + number1 + " - " + number2);
Console.WriteLine("[M]ultiply: " + number1 + " x " + number2);
Console.WriteLine("E[x]it");

var choice = Console.ReadLine();

if (choice.ToUpper() == "A")
{
    Add(number1, number2);
}
else if (choice.ToUpper() == "S")
{
    Subtract(number1, number2);
}
else if (choice.ToUpper() == "M")
{
    Multiply(number1, number2);
}
else if (choice.ToUpper() == "X")
{
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Invalid option");
}

void Add(int num1, int num2)
{
    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
}

void Subtract(int num1, int num2)
{
    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
}

void Multiply(int num1, int num2)
{
    Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
}

Console.ReadKey();