
Console.Clear();
Console.WriteLine("Vvedite A chislo: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite B chislo: ");
int b =Convert.ToInt32(Console.ReadLine());

if (b==0)
Console.WriteLine($"Chislo A({a}) vozvedenoe v stepen B({b}) = 0");
else
{
int step=1;

for(int i=0;i<b;i++)
{
    step=step*a;
}

Console.WriteLine($"Chislo A({a}) vozvedenoe v stepen B({b}) = {step}");
}