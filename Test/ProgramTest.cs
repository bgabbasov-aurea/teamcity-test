using ConsoleApp;
using Xunit;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void Sum()
        {
            var a = 2;
            var b = 3;

            var result = Program.Sum(a, b);

            Assert.Equal(5, result);
        }
    }
}
