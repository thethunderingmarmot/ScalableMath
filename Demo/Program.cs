// See https://aka.ms/new-console-template for more information
using ScalableMath;

Console.WriteLine("Hello, World!");

INumber number1 = INumber.GetPerformantNumber();
INumber number2 = INumber.GetLimitlessNumber();

number1.Add(number2);
Console.WriteLine(number1);