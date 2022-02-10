class Exercise3_4
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter another number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter another number: ");
        int num3 = int.Parse(Console.ReadLine());
        bool num1Highest = (num1 > num2 && num1 > num3);
        bool num2Highest = (num2 > num1 && num2 > num3);
        bool num3Highest = (num3 > num1 && num3 > num2);

        Console.WriteLine("The numbers entered in descending order are");
        if (num1Highest)
        {
            Console.Write(num1 + ", ");
            if (num2 > num3)
            {
                Console.Write(num2 + ", ");
                Console.Write(num3);
            }
            else
            {
                Console.Write(num3 + ", ");
                Console.Write(num2);
            }
        }

        if (num2Highest)
        {
            Console.Write(num2 + ", ");
            if (num1 > num3)
            {
                Console.Write(num1 + ", ");
                Console.Write(num3);
            }
            else
            {
                Console.Write(num3 + ", ");
                Console.Write(num1);
            }
        }

        if (num3Highest)
        {
            Console.Write(num3 + ", ");
            if (num1 > num2)
            {
                Console.Write(num1 + ", ");
                Console.Write(num2);
            }
            else
            {
                Console.Write(num2 + ", ");
                Console.Write(num1);
            }
        }

    }
}