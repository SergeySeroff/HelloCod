// Вид 1
/*
void Method1() // название метода
{
    Console.WriteLine("Автор .... "); // тело метода
}
Method1(); // вызов метода
*/


// Вид2
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сщщбщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4); // ctrl + c остановка терминала
Method21(count: 4, msg: "новый текст"); // именованные аргументы не обязательно писать по порядку
*/

// Вид 3
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// Вид 4
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "zaz");
Console.WriteLine(res);
*/

// Вид5

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "zaz");
Console.WriteLine(res);