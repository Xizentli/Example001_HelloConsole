int numberA = new Random().Next(1, 10); //случайное число 1 2 3 4 5 6 7 8 9 (без десятки)
Console.Write("numberA="); 
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.Write("numberB=");
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
