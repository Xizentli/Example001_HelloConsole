//Нахождение максимума из 9ти чисел с добавлением массивов

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1; // определяем переменную, в кот.будет храниться максимальное значение
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//             0   1   2   3   4   5  6   7  8
int[] array = {13, 52, 37, 42, 1425, 6, 72, 8, 9};
//array[0] = 12; //обращение к массиву и присвоение ему значения
//Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);