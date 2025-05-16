public class MyMath
{
    static void PrimeFactors()
    {
        Console.WriteLine("Enter a number to be factored:");
        int n = Convert.ToInt32(Console.ReadLine());
        int original = n;

        List<int> factors = [];

        while (n % 2 == 0)
        {
            factors.Add(2);
            n /= 2;
        }

        for (int i = 3; i * i <= n; i += 2)
        {
            while (n % i == 0)
            {
                factors.Add(i);
                n /= i;
            }
        }
        if (n > 2)
        {
            factors.Add(n);
        }
        Console.WriteLine($"Prime factors of {original} are: " + (string.Join(" x ", factors)));
    }
    static void Main()
    {
        PrimeFactors();
    }
    
    public static List<int> GetPrimeFactors(int n)
    {
        List<int> factors = new List<int>();

        while (n % 2 == 0)
        {
            factors.Add(2);
            n /= 2;
        }

        for (int i = 3; i * i <= n; i += 2)
        {
            while (n % i == 0)
            {
                factors.Add(i);
                n /= i;
            }
        }

        if (n > 2)
        {
            factors.Add(n);
        }

        return factors;
    }

}