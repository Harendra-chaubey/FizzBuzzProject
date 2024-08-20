using FizzBuzz.Interface;
namespace FizzBuzz.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private const int DivisorThree = 3;
        private const int DivisorFive = 5;

        private const string FizzBuzzResult = "FizzBuzz";
        private const string FizzResult = "Fizz";
        private const string BuzzResult = "Buzz";


        public string GetFizzBuzzResult(int number)
        {
            if (number % DivisorThree == 0 && number % DivisorFive == 0)
            {
                return FizzBuzzResult;
            }
            else if (number % DivisorThree == 0)
            {
                return FizzResult;
            }
            else if (number % DivisorFive == 0)
            {
                return BuzzResult;
            }
            else
            {
                // Return the division attempts as required
                return $"Divided {number} by {DivisorThree}\nDivided {number} by {DivisorFive}";
            }

        }
    }
}
