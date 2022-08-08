// int a = 4;
// int b = 5;
// Console.WriteLine ("a^b = " + Math.Pow(a, b));

Console.WriteLine("введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = a;
for (int i = 1; i < b; i++)
{
stepen = stepen * a;
}
Console.WriteLine("a в степени b = " + stepen);