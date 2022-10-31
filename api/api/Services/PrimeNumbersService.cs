namespace api.Services
{
    public static class PrimeNumbersService
    {
        internal static int[] GetPrimeNumbers(int i)
        {
            List<int> numbers = new List<int>();

            for (int j = 2; j < i; j++)
            {
                if (IsPrime(j))
                {
                    numbers.Add(j);
                }
            }

            return numbers.ToArray();
        }

        private static bool IsPrime(int i)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
