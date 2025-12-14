# MS-Test-Demo

## Create MSTest Project
Create "MSTest Test Project" Project
* Naming Convention: <ClassUnderTest>tests

## Add Project Reference
Your test project will exist independently of the project you intend to test. This means we need to add a reference from the test project to the project under test.
* Right click your MSTest Test Project
* Select "Add Project Reference"
* Select the project under test

## Creating Test Methods
* Test Methods should be named to clearly define the function of the test.
* Test Classes in MSTest Test Projects require the [TestClass] attribute.
* Test Methods in MSTest Test Projects require the [TestMethod] attribute.

## Using Tests
* After writing an MSTest in VSCode there will be a tiny play button to the left of the test method and it will allow you to run the test
* Or you can go to View then Testing to open the testing window in vs code.

## AAA Framework (Arrange-Act-Assert)

The AAA pattern is a standard way to structure unit tests, making them easier to read and maintain:

### Arrange
Set up the test conditions and prepare everything needed for the test:
* Create instances of classes (objects under test)
* Initialize variables with test data
* Set up mock objects or dependencies
* Configure the initial state

**Example:**
```csharp
var calculator = new Calculator();
int firstNumber = 5;
int secondNumber = 3;
```

### Act
Execute the specific action or method you're testing:
* Call the method being tested with the arranged parameters
* This should typically be a single line of code
* Capture the result in a variable

**Example:**
```csharp
int result = calculator.Add(firstNumber, secondNumber);
```

### Assert
Verify that the action produced the expected result:
* Use `Assert` methods to compare expected vs actual values
* Common assertions:
  * `Assert.AreEqual(expected, actual)` - Values should match
  * `Assert.IsTrue(condition)` - Condition should be true
  * `Assert.IsNotNull(object)` - Object should not be null
  * `Assert.ThrowsException<ExceptionType>()` - Should throw specific exception

**Example:**
```csharp
Assert.AreEqual(8, result);
```

### Complete Test Example
```csharp
[TestMethod]
public void Add_TwoPositiveNumbers_ReturnsSum()
{
    // Arrange
    var calculator = new Calculator();
    int firstNumber = 5;
    int secondNumber = 3;
    
    // Act
    int result = calculator.Add(firstNumber, secondNumber);
    
    // Assert
    Assert.AreEqual(8, result);
}
```