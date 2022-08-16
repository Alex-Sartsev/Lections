void Method1() // Первая группа методов, которая ничего не принимает и не возвращает 
{
    System.Console.WriteLine("Автор ...");
}
Method1();

// .......................................................................................

void Method2(string msg, int count) // Метод, который принимает два типа значений, но ничего не возвращает
{
    int i = 0;
    while (i < count) {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2(msg: "Текст", count: 4);
Method2(count: 4, msg: "Новый текст");

// .......................................................................................

int Method3() // Метод, который ничего не принимает, но возвращает текущий год
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// .......................................................................................

string Method4(int count, string text) // Метод, который принимает два типа значений, и их возвращает
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);