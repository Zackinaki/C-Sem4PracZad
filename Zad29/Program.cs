
Console.Clear();

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.Write($"Vvedite {i + 1} element massiva: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Massiv emet vid: [{string.Join(", ", array)}]");