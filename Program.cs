namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = "3,5";
            int result = multi(input);
            Console.WriteLine(result);
            static int multi(string input)
            {
                string[] parts = input.Split(",");
                int num1 = int.Parse(parts[0]);
                int num2 = int.Parse(parts[1]);
                return  num1 * num2;
            }
            
        }
    }
}
