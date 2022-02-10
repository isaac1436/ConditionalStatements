class Exercise2
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter another number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter another number: ");
        int num3 = int.Parse(Console.ReadLine());

        if ((num1 < 0 ^ num2 < 0 ^ num3 < 0) || (num1 < 0 && num2 < 0 && num3 < 0))
        {
            Console.WriteLine("The product of the numbers listed would be negative(-)");
        }
        else
        {
            Console.WriteLine("The product of the numbers listed would be positive(+)");
        }
        Console.WriteLine("The product of the three numbers is " + (num1 * num2 * num3));
    }
}