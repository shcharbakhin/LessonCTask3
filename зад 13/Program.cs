{
    int A, B, C, D, E;
    Console.WriteLine("Введите трехзначное число");
    A = Convert.ToInt32(Console.ReadLine());
    B = A % 10;
    C = (A / 10) * 10;
    E = (A / 1000) * 1000;
    if (100 > A)
    {
        Console.WriteLine("В числе нет третье цифры");
    }
    else
    {
        D = (A - B - C - E) / 100;
        Console.Write("Третья цифра числа: ");
        Console.WriteLine(D);
    }
}