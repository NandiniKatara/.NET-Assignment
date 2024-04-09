namespace AddTwoNumbers
{
    internal class Program
    {
        static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of Two Numbers : ");
            Console.WriteLine("Enter first number : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            double num2 = double.Parse(Console.ReadLine());
            double sum = Addition(num1, num2);
            Console.WriteLine($"Result : {num1} + {num2} = {sum}");

        }
    }
}
