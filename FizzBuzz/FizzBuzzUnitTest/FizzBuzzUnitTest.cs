using FizzBuzz.Controllers;
using FizzBuzz.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework.Legacy;

namespace FizzBuzzUnitTest
{
    public class FizzBuzzTests
    {
        private Mock<IFizzBuzzService> _fizzBuzzServiceMock;
        private FizzBuzzController _controller;

        [SetUp]
        public void Setup()
        {
            // Create the mock for IFizzBuzzService
            _fizzBuzzServiceMock = new Mock<IFizzBuzzService>();

            // Inject the mock into the controller
            _controller = new FizzBuzzController(_fizzBuzzServiceMock.Object);
        }

        [Test]
        public void Test_ActionResult_Returns_WhenValidInputItem()
        {
            // Arrange
            string[] numbers = new string[] { "3", "5" };
            string[] expected = new string[] { "Fizz", "Buzz" };

            _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(int.Parse(numbers[0])))
                                .Returns("Fizz");
            _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(int.Parse(numbers[1])))
                                .Returns("Buzz");

            // Act
            var result = _controller.Get(numbers) as OkObjectResult;
            var actual = result?.Value as IEnumerable<string>;
            // Assert
            ClassicAssert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual.ToArray());

        }

        [Test]
        public void Test_ActionResult_Returns_WhenInValidInputItem()
        {
            // Arrange
            string[] numbers = new string[] { "20"};
            string[] expected = new string[] { "Invalid item." };

            _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(int.Parse(numbers[0])))
                                .Returns("Invalid item.");
          
            // Act
            var result = _controller.Get(numbers) as OkObjectResult;
            var actual = result?.Value as IEnumerable<string>;
           
            ClassicAssert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual.ToArray());

        }
    }
}