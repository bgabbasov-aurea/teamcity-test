using ConsoleApp;
using FluentAssertions;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void Sum()
        {
            var a = 2;
            var b = 3;

            var result = Program.Sum(a, b);

            result.Should().Be(5);
        }
    }
}
