int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 20);
int index = 0;

while (index < count);
{
    array[index] = new Random().Next(1, 20);
    index += 1;
}

index = 0;
while (index < count)
{
    if (array[index] = find)
    {
        Console.WriteLine("Yes");
    }
    index += 1;
}
Console.WriteLine("end");