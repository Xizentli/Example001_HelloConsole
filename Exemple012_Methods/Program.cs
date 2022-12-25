//--------------1я группа методов: ничего не принимают, ничего не возвращают--------------
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();







//--------------2я группа методов: принимают какие-то аргументы, но в то же время ничего не возвращают--------------
void Method2(string arg)
{
    Console.WriteLine(arg);
}
Method2("Текст сообщения"); 
//можно записать еще так: 
Method2(arg: "New: Текст сообщения");

//так же есть так называемые именованные аргументы, когда явно можно указать, какому аргументу какое значение нужно указать
//это часто нужно в случае если методы принимают несколько аргументов
void Method21(string arg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(arg);
        i++;
    }  
}
Method21("Сообщение", 4); //печатаем "Сообщение" 4 раза. 
//Можно записать еще так: 
Method21(arg: "New: Сообщение", count: 4);
//Или так (не по порядку):
Method21(count: 4, arg: "New: Сообщение 2");







//--------------3я группа методов: ничего не принимают, но что-то возвращают--------------
int Method3()
{
    return DateTime.Now.Year; //текущий год
}
int year = Method3();
Console.WriteLine(year);







//--------------4я группа методов: что-то принимают, что-то возвращают--------------
string  Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //необходимо что-то положить в эту переменную, например: пустую строку = "", 
                                  //более правильно стоит написать String.Empty
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Текст"); //будем склеивать Текст 10 раз
Console.WriteLine(res);


//////////////////////////////////////////пример цикла for
string  Method41(int count, string text)
{
    string result = String.Empty; //необходимо что-то положить в эту переменную, например: пустую строку = "", 
                                  //более правильно стоит написать String.Empty
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res41 = Method41(10, "o");
Console.WriteLine(res41);


//////////////////////////////////////////пример цикла в цикле: вывод таблицы умножения на экран

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}







///////////////////////////////////////работа с текстом:
/*
Дан текст.
Все пробелы заменить на черточки.
Маленькие "к" заменить большими "К".
Большие "С" заменить маленькими "с".
*/

string txt = "- Опять ты злишься, - Юрий вздохнул и отключился."
           + "Эрик положил сотовый телефон в карман и машинально достал одну сигарету. Он покрутил её в пальцах и выбросил в мусорный ящик."
           + "- Черт, не хорошо-то как получилось, - пробормотал он и залез в свою машину.";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string txt, char oldValue, char newValue)
{
    string result = String.Empty; //пустая строка
    int length = txt.Length;
    for (int i = 0; i < length; i++)
    {
        if(txt[i] == oldValue) result = result + $"{newValue}"; // если текущий символ совпал с тем символом, кот.мы хотим заменить, 
                                                                // то в результат мы должны положить новое значение в виде строки
        else result = result + $"{txt[i]}"; //если же совпадений не обнаружено, то в результат нужно добавить текущий символ, кот.и был
    }
    return result;
}

string newTxt = Replace(txt, ' ', '_'); //заменяем пробелы подчерками
Console.WriteLine(newTxt);
Console.WriteLine();

newTxt = Replace(newTxt, 'к', 'К');
Console.WriteLine(newTxt);
Console.WriteLine();

newTxt = Replace(newTxt, 'с', '+');
Console.WriteLine(newTxt);
Console.WriteLine();







///////////////////////////////////////Сортировка массива

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 2};

void PrintArray(int[] array) //метод, кот.выводит массив на экран
{
    int count = array.Length; //длина массива
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод, кот.упорядочивает элементы массива
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        //ищем минимальный элемент
        for(int j = i + 1; j < array.Length; j++)//i+1 - начинаем со второго элемента после определенного i
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        //меняем минимальный элемент с первым неотсортированным элементом
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr); //печатаем первоначальный массив
SelectionSort(arr); //сортируем массив
PrintArray(arr); //печатаем отсортированный массив