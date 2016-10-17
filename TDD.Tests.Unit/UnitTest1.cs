using NUnit.Framework;
using Shouldly;

namespace TDD.Tests.Unit
{
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            true.ShouldBe(true);
        }
    }
}