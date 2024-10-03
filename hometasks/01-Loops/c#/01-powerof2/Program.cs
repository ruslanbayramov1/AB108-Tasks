int num = Convert.ToInt32(Console.ReadLine());
int pow = 0;

for (int i = 2; i <= num; i *= 2)
{
    pow++;
}

Console.WriteLine(pow);
