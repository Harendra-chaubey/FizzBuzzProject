using FizzBuzz.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpPost]
        public IActionResult Get([FromBody] string[] inputs)
        {
            var results = new List<string>();
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    results.Add("Invalid item");
                }
                else if (int.TryParse(input, out int number))
                {
                    results.Add(_fizzBuzzService.GetFizzBuzzResult(number));
                }
                else
                {
                    results.Add("Invalid item");
                }
            }
            return Ok(results);
        }
    }
}
