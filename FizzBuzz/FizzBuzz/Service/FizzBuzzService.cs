using FizzBuzz.Interface;
namespace FizzBuzz.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private const int DivisorThree = 3;
        private const int DivisorFive = 5;
        public string GetFizzBuzzResult(int number)
        {
            if (number % DivisorThree == 0 && number % DivisorFive == 0)
            {
                return "FizzBuzz";
            }
            else if (number % DivisorThree == 0)
            {
                return "Fizz";
            }
            else if (number % DivisorFive == 0)
            {
                return "Buzz";
            }
            else
            {
                // Return the division attempts as required
                return $"Divided {number} by {DivisorThree}\nDivided {number} by {DivisorFive}";
            }

        }
    }
}
