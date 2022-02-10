class Exercise1 
{ 
    static void Main(string[] args)
    {
       
            Console.Write("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The two numbers entered are " + num1 + " and " + num2);

            if (num1 > num2)
            {
                num1 += num2;
                num2 = Math.Abs(num2 - num1);
                num1 -= num2;
                Console.WriteLine("The values when switched are: {0} and {1}",num1, num2);
            }
        else
        {
            Console.Write(num1 + " is not greater than " + num2);
        }
       
    }
}