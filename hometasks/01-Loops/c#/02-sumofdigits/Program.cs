int num = Convert.ToInt32(Console.ReadLine());
int digit;
int sumDigit = 0;

do
{
    digit = num % 10;
    num = (num - digit) / 10;
    sumDigit += digit;
}
while (num > 0);

Console.WriteLine(sumDigit);