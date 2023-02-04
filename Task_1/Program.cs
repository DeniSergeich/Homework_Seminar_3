Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if (num > 99999 || num < 10000)
{
    Console.WriteLine("Некорректный ввод! Введите пятизначное число!");
    return;
}
if (num / 10000 == num % 10)
{
    if ((num % 100) / 10 == (num / 1000) % 10)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не является палиндромом");
}