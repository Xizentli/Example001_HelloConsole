﻿//Нахождение максимума из 9ти чисел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1; // определяем переменную, в кот.будет храниться максимальное значение
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 2100;
int c1 = 39;
int a2 = 12;
int b2 = 21235473;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 333;

//int max1 = Max(a1, b1, c1); 
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


Console.WriteLine(max);