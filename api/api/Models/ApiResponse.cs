namespace api.Models
{
    public class ApiResponse
    {
        public int[] PrimeNumbers { get; set; }

        public ApiResponse(int[] primeNumbers)
        {
            PrimeNumbers = primeNumbers;
        }
    }
}
