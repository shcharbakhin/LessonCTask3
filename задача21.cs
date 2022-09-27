
{
    double[] x = new double[6];
    double R, rasstoyanie = 0.0;
    Console.WriteLine("Введите координаты точек через пробел в соответствии со схемой: x1 y1 z1 x2 y2 z3:");
    var tochki = Console.ReadLine().Split();
    for (int i = 0; i < 3; i++)
    {
        R = Convert.ToDouble(tochki[i + 3])
    - Convert.ToDouble(tochki[i]);
        rasstoyanie += R * R;
    }
    Console.WriteLine("расстояние между точками = " + Math.Sqrt(rasstoyanie));
}