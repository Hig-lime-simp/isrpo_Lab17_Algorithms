while (true)
{
    Console.Write("\nВведите число для проверки: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 2)
    {
        Console.WriteLine($"Число {number} не является простым (простые числа начинаются с 2)");
        continue;
    }

    bool isPrime = IsPrime(number);

    if (isPrime)
    {
        Console.WriteLine($"Число {number} является ПРОСТЫМ");
        break;
    }
    else
    {
        Console.WriteLine($"✗ Число {number} является СОСТАВНЫМ");
        break;
    }
}
    
static bool IsPrime(int n)
{
    if (n < 2)
        return false;

    if (n == 2)
        return true;

    if (n % 2 == 0)
        return false;

    int limit = (int)Math.Sqrt(n);
    for (int i = 3; i <= limit; i += 2)
    {
        if (n % i == 0)
            return false;
    }
    
    return true;
}