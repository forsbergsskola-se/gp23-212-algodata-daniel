using NUnit.Framework;
using TurboCollections;

namespace TurboCollections.test;

public static class TurboMathsTests
{
    [Test]
    public static void SayHelloExists()
    {
        TurboMaths.SayHello();
        Assert.Pass();
    }
}