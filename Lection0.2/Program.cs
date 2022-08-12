// Поиск максимума из 9 чисел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = new Random().Next(0, 100);
int a2 = new Random().Next(0, 100);
int a3 = new Random().Next(0, 100);
int b1 = new Random().Next(0, 100);
int b2 = new Random().Next(0, 100);
int b3 = new Random().Next(0, 100);
int c1 = new Random().Next(0, 100);
int c2 = new Random().Next(0, 100);
int c3 = new Random().Next(0, 100);

int max = Max(
    Max(a1, a2, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);