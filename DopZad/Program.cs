Console.Clear();
Console.Write("Vvedite kol-vo elementov: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Vvedite {i + 1} element massiva: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.Write("Vvedite chislo k: ");
int k = Convert.ToInt32(Console.ReadLine());

if (k>0)
{
    k=k%n;

}
else
{
    k=n-((-k)%n);

}

Console.WriteLine("Poluchennai posled-t': ");

for(int i=n-k;i<n;i++)
{
    Console.Write($"{array[i]} ");
}
for(int i=0;i<n-k;i++)
{
    Console.Write($"{array[i]} ");
}


