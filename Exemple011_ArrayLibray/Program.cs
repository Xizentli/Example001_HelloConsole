
//метод, который заполнит пустой массив случайными числами
void FillArray(int[] collection)
{
    int length = collection.Length; //длина массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //заполняем случайными числами от 1 до 10
        index++;
    }
}

//Метод, который печатает массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //проверка: если какого-то элемента нет, то возвращать будет 0 (можно спутать с нулевой позицией). 
                       //-1 решит эту проблему, вернув -1, эсли такого элемента нет.
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создать новый массив, в кот. будет 10 элементов (по-умолчанию будет заполнен нулями)

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444); //находится самое последнее входжение
Console.WriteLine(pos);
