// See https://aka.ms/new-console-template for more information
using ScalableMath;

Console.WriteLine("Hello, World!");

INumber number1 = INumber.Numberify(5);
INumber number2 = INumber.Numberify(3);

number1.Add(number2);
Console.WriteLine(number1);