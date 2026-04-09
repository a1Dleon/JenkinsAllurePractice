using Allure.NUnit;
using Allure.NUnit.Attributes;
using practice05.TestData;

namespace practice05;
[AllureNUnit]
public class Tests
{
    [TestCaseSource(typeof(NumbersData), nameof(NumbersData.Sum_Data))]
    [Test]
    public void OperationsValidation(int a, int b, int expected)
    {
        int sumResult = Sum(a,b);
        int diffResult = Diff(sumResult, b);
        int multiplyResult = Multiply(diffResult, b);
        int divResult = Division(multiplyResult, b);
        Assert.That(divResult, Is.EqualTo(expected));
    }
    
    [AllureStep("Sum Step")]
    public int Sum(int a, int b)
    {
        return a+b;
    }
    
    [AllureStep("Diff Step")]
    public int Diff(int a, int b)
    {
        return a-b;
    }
    
    [AllureStep("Multiply Step")]
    public int Multiply(int a, int b)
    {
        return a*b;
    }
    
    [AllureStep("Division Step")]
    public int Division(int a, int b)
    {
        return a/b;
    }
}
