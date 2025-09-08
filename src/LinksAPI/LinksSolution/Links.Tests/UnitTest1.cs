namespace Links.Tests;

public class UnitTest1
{
    [Fact] // Attribute Like ([HttpPost("/links")]
    public void Test1()
    {
        int a = 10, b = 20, answer;
        answer = a + b;
        Assert.Equal(30, answer);
    }
}
