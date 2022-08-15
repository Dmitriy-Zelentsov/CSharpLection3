// Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.
string text = "Я думаю, — сказал князь, улыбаясь, — что,"
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля. "
            +"Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i]==oldValue) result = result + $"{newValue}";
        else
        result = result + $"{text[i]}";
    }
    return result;
}
string new_text = Replace(text, ' ', '|');
Console.WriteLine (new_text);

Console.WriteLine ();
Console.WriteLine ();

string new_text2= Replace(new_text, 'к', 'К');
Console.WriteLine (new_text2);

Console.WriteLine ();
Console.WriteLine ();

string new_text3= Replace(new_text2, 'С', 'с');
Console.WriteLine (new_text3);




