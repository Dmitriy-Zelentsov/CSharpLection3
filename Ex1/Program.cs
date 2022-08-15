// 1 Группа методов, коорые ничего не принимают и не возвращают
void Method1()
{
    Console.WriteLine("Автор:ЗДМ");
}
//Method1();




//2 Группа методов, коорые ничего не возвращают, но принимают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg:"текст сообщения");




//3 Группа методов, коорые что-то возвращают, но не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);




//4 Группа методов, коорые что-то принимают и что-то возвращают
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(3, "x");
//Console.WriteLine(res);



///4 Группа методовcс помощью цикла for
//string Method4(int count, string c)
//{
    //string result = String.Empty;
    //for (int i = 0; i < count; i++)
    //{
        //result = result + c;
    //}
    //return result;
//}
//string res = Method4(3, "x");
//Console.WriteLine(res);



//Задача вывода таблицы умножения на экран

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();
}

