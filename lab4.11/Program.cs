int[] mas = new int[7];
Console.WriteLine("введите 7 двух значных чисел");
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int number) && number >= 10 && number <= 99)
    {
        mas[i] = number;

    }
    else
    {
        Console.WriteLine("Ошибка: введите двухзначное число.");
    }
}
int[] m = new int[mas.Length];

for (int i = 0; i < mas.Length; i++)
{
    m[i] = mas[i] / 10;
}


Console.WriteLine("Новый массив (старшие разряды):");
foreach (var var in m)
{
    Console.Write(var + " ");
}