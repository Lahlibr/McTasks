namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "3,5";
            string[] parts = input.Split(",");
            int num1 = int.Parse(parts[0]);
            int num2 = int.Parse(parts[1]);
            int result = num1 * num2;
            Console.WriteLine(result);
        }
    }
}
