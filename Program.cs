{
    int PalinD (int pal)
{
    Console.WriteLine("Введите пятизначное число");
    int pal = Convert.ToInt32(Console.ReadLine());
    if (pal < 100000 && pal > 9999)
    {
        int a = pal;
        string s = a.ToString();
        char[] ar = s.ToCharArray();
        Array.Reverse(ar);
        s = new String(ar);
        a = Convert.ToInt32(s);
        if (a == pal)
        {
            Console.WriteLine("Число - палиндром");
        }
        else
        {
            Console.WriteLine("Число - не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели неправильное число. Перезапустите программу");
    }

}
}
