# FizzBuzz API

## Introduction

The FizzBuzz API is a simple web service built using .NET Core that implements the classic FizzBuzz game. In this game, the API takes an array of integers as input and returns the corresponding FizzBuzz results. The rules are straightforward:
- For numbers divisible by 3, the API returns "Fizz".
- For numbers divisible by 5, the API returns "Buzz".
- For numbers divisible by both 3 and 5, the API returns "FizzBuzz".
- For all other numbers, the API returns the number itself.

This API can be used as a simple exercise in understanding web services or as a building block for more complex applications that involve numeric processing.

## How to Run

1. **Clone the Repository:**
   - Use the following command to clone the repository:
     ```bash
     git clone https://github.com/yourusername/fizzbuzz-api.git
     ```
  
2. **Open the Solution:**
   - Navigate to the folder where the repository was cloned and open the solution file (`.sln`) in Visual Studio 2022.

3. **Set the API as Startup Project:**
   - In Visual Studio, right-click on the FizzBuzz API project in the Solution Explorer and select "Set as Startup Project".

4. **Restore Dependencies:**
   - Visual Studio should automatically restore any missing NuGet packages. If not, right-click on the solution and select "Restore NuGet Packages".

5. **Build the Solution:**
   - Ensure that the solution builds successfully by clicking on "Build" > "Build Solution" or pressing `Ctrl+Shift+B`.

6. **Run the Application:**
   - Press `F5` or click on the "Start Debugging" button to run the application. This will launch the API locally on your machine.

## How to Test

1. **Open the Test Explorer:**
   - In Visual Studio, go to "Test" > "Test Explorer" to view all available tests.

2. **Ensure Test Project is Included:**
   - Make sure that the test project (usually named `FizzBuzzApi.Tests` or similar) is included in the solution and that the tests are displayed in the Test Explorer.

3. **Run All Tests:**
   - Click "Run All" in the Test Explorer to execute all unit tests. Ensure that all tests pass without any errors.

## Requirements

- **.NET Core Framework:** Ensure that you have the latest .NET Core SDK installed on your machine.
- **Visual Studio 2022:** Required for development, running, and testing the application.
- **NUnit:** Used as the testing framework.
- **Moq:** Utilized for creating mock objects in unit tests.

## Additional Notes

- **API Endpoints:** You may want to document the available API endpoints, input/output formats, and any other relevant details for users who might consume the API.
- **Deployment:** If you plan to deploy the API, include instructions for deployment (e.g., to Azure or AWS).

