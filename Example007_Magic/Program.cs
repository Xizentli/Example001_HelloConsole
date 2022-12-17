Console.Clear(); //отчистка консоли
//Console.SetCursorPosition(10,4); //(отступ от левого края, отступ от верхнего края)
//Console.WriteLine("+");

int xa = 40, ya = 1, 
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb;
int count = 0; //счетчик

while(count < 100)
{
    int what = new Random().Next(0, 3); //генерируем случайное число в полу-интервале [0;3) 0 1 2 (выбираем одну из трех точек)
    //определяем первую точку
    if(what == 0) // если случайное число равно нулю (делаем проверку)
    {
        x = (x + xa)/2; // то в х нужно положить середину отрезка
        y = (y + ya)/2; // и в у тоже
    }
    //определяем вторую точку
    if(what == 1) // если случайное число равно нулю (делаем проверку)
    {
        x = (x + xb)/2; // то в х нужно положить середину отрезка
        y = (y + yb)/2; // и в у тоже
    }
    //определяем третью точку
    if(what == 2) // если случайное число равно нулю (делаем проверку)
    {
        x = (x + xc)/2; // то в х нужно положить середину отрезка
        y = (y + yc)/2; // и в у тоже
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count +=1; //можно указать: count +=1; или count++;
}