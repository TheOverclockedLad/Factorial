namespace Factorial.CLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1 || !uint.TryParse(args[0], out uint number))
            {
                Console.WriteLine("Usage: Factorial <a positive integer>");
                return;
            }

            Console.WriteLine(Factorial(number));
        }

        public static uint Factorial(uint number)
        {
            uint factorial = 1;
            for (uint i = 1; i <= number; i++)
                factorial *= i;

            return factorial;
        }
    }
}
