int num = Convert.ToInt32(Console.ReadLine());

if (num <= 1)
{
    Console.WriteLine("neither complex nor simple number");
}
else if (num == 2)
{
    Console.WriteLine("simple number");
}
else if (num % 2 == 0)
{
    Console.WriteLine("complex number");
}
else
{
    bool isComplex = false;
    for (int i = 3; i * i <= num; i += 2)
    {
        if (num % i == 0)
        {
            Console.WriteLine("complex number");
            isComplex = true;
            break;
        }
    }

    if (!isComplex) 
        Console.WriteLine("simple number");
}
