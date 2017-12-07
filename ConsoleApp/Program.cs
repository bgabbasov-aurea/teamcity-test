using log4net;

namespace ConsoleApp
{
    public class Program
    {
        private static ILog Log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            Log.Info("Hello, world!");
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
