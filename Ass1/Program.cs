namespace Ass1
{
    internal class Program
    {
        static List<int> FindPrimes(int n, int m)
        {
           
            if (n < 1 || m > 1000000 || n >= m)
            {
               Console.WriteLine("Invalid input range");
            }
            bool[] isPrime = new bool[m + 1];
            for (int i = 2; i <= m; i++)
            {
                isPrime[i] = true;
            } 

            for (int i = 2; i * i <= m; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= m; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            List<int> primes = new List<int>();
            for (int i = Math.Max(2, n+1); i <= m; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter two integers n and m :");
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            List<int> primes = FindPrimes(n, m);
            Console.WriteLine(string.Join(" ", primes));
        }
    }
}
