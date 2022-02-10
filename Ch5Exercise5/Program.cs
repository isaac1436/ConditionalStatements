class Ch5Exercise5
{
    static void Main()
    {
        Console.Write("Please enter a number from 0-9: ");
        int num=int.Parse(Console.ReadLine());

        switch (num)
        {
            case 0:
                Console.WriteLine("The number in words is Zero");
                break;
            case 1:
                Console.WriteLine("The number in words is One");
                break;
            case 2:
                Console.WriteLine("The number in words is Two");
                break;
            case 3:
                Console.WriteLine("The number in words is Three");
                break;
            case 4:
                Console.WriteLine("The number in words is Four");
                break;
            case 5:
                Console.WriteLine("The number in words is Zero");
                break;
            case 6:
                Console.WriteLine("The number in words is Zero");
                break;
            case 7:
                Console.WriteLine("The number in words is Zero");
                break;
            case 8:
                Console.WriteLine("The number in words is Zero");
                break;
            case 9:
                Console.WriteLine("The number in words is Zero");
                break;
            default:
                Console.WriteLine("Don't be cheeky, enter a number in the range specified");
                break;
        }
        }
}