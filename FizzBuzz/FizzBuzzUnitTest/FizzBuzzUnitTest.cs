using FizzBuzz.Controllers;
using FizzBuzz.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework.Legacy;

namespace FizzBuzzUnitTest
{
    [TestFixture]
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

        //[Test]
        //public void Test_ActionResult_Returns_WhenValidInputItem()
        //{
        //    // Arrange
        //    string[] numbers = new string[] { "3", "5" };
        //    string[] expected = new string[] { "Fizz", "Buzz" };

        //    _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(int.Parse(numbers[0])))
        //                        .Returns("Fizz");
        //    _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(int.Parse(numbers[1])))
        //                        .Returns("Buzz");

        //    // Act
        //    var result = _controller.Get(numbers) as OkObjectResult;
        //    var actual = result?.Value as IEnumerable<string>;
        //    // Assert
        //    ClassicAssert.IsNotNull(actual);
        //    CollectionAssert.AreEqual(expected, actual.ToArray());

        //}

        //[Test]
        //public void Test_ActionResult_Returns_WhenInValidInputItem()
        //{
        //    // Arrange
        //    string[] numbers = new string[] { "20"};
        //    string[] expected = new string[] { "Invalid item." };

        //    _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(int.Parse(numbers[0])))
        //                        .Returns("Invalid item.");
          
        //    // Act
        //    var result = _controller.Get(numbers) as OkObjectResult;
        //    var actual = result?.Value as IEnumerable<string>;
           
        //    ClassicAssert.IsNotNull(actual);
        //    CollectionAssert.AreEqual(expected, actual.ToArray());

        //}

        [Test]
        public void Test_WhenNumberIsDivisibleByThree()
        {
            // Arrange
            int number = 3;
            string expected = "Fizz";

            _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(number))
                                .Returns(expected);

            // Act
            var result = _controller.Get(new string[] { number.ToString() }) as OkObjectResult;
            var actual = result?.Value as IEnumerable<string>;

            // Assert
            ClassicAssert.IsNotNull(actual);
            ClassicAssert.AreEqual(expected, actual?.First());
        }


        [Test]
        public void Test_WhenNumberIsDivisibleByFive()
        {
            // Arrange
            int number = 5;
            string expected = "Buzz";

            _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(number))
                                .Returns(expected);

            // Act
            var result = _controller.Get(new string[] { number.ToString() }) as OkObjectResult;
            var actual = result?.Value as IEnumerable<string>;

            // Assert
            ClassicAssert.IsNotNull(actual);
            ClassicAssert.AreEqual(expected, actual?.First());
        }


        [Test]
        public void Test_WhenNumberIsDivisibleByThreeAndFive()
        {
            // Arrange
            int number = 15;
            string expected = "FizzBuzz";

            _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(number))
                                .Returns(expected);

            // Act
            var result = _controller.Get(new string[] { number.ToString() }) as OkObjectResult;
            var actual = result?.Value as IEnumerable<string>;

            // Assert
            ClassicAssert.IsNotNull(actual);
            ClassicAssert.AreEqual(expected, actual?.First());
        }

        [Test]
        public void Test_WhenNumberIsNotDivisibleByThreeOrFive()
        {
            // Arrange
            int number = 7;
            string expected = "Divided 7 by 3\nDivided 7 by 5";

            _fizzBuzzServiceMock.Setup(service => service.GetFizzBuzzResult(number))
                                .Returns(expected);

            // Act
            var result = _controller.Get(new string[] { number.ToString() }) as OkObjectResult;
            var actual = result?.Value as IEnumerable<string>;

            // Assert
            ClassicAssert.IsNotNull(actual);
            ClassicAssert.AreEqual(expected, actual?.First());
        }


        [Test]
        public void Test_WhenInputIsString()
        {
            // Arrange
            string input = "abc";

            // Act & Assert
            Assert.Throws<FormatException>(() => int.Parse(input));
        }

        [Test]
        public void Test_WhenInputIsEmpty()
        {
            // Arrange
            string input = "";

            // Act & Assert
            Assert.Throws<FormatException>(() => int.Parse(input));
        }

        [Test]
        public void Test_WhenInputIsNull()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => int.Parse(input));
        }
    }
}