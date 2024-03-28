using ScalableMath;

INumber number1 = new ByteListNumber();
INumber number2 = new ByteArrayNumber();

number1.Add(number2);
Console.WriteLine(number1);