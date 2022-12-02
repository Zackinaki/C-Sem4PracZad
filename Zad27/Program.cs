Console.Clear();
Console.Write("Vvedite chislo: ");
string? n = Console.ReadLine();

int sum=0;
for (int i = 0; i < n.Length; i++)
{

sum=sum+int.Parse(n[i].ToString());

}

Console.WriteLine($"Summa cifr v chisle({n}) ravna {sum}");