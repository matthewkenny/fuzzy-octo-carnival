using Xunit;
namespace App.Tests;

public class Tests
{
    [Fact]
    public void Test1()
    {
        // Note: this test will not run because no shim is supplied for xunit.
        Assert.Equal(4, Program.Add(2, 2));
    }
}

public static class TestSuite
{
    public static int Main()
    {
        // Provide an entry point just so the project can build as a test.
        System.Console.WriteLine("This is not an XUnit shim.");
        return 1;
    }
}