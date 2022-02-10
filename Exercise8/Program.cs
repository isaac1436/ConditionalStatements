class exercise8
{
    static void Main()
    {
        int num;
        Console.WriteLine("Welcome to my input manager");
        Console.WriteLine("Input 1 to enter an Integer");
        Console.WriteLine("Input 2 to enter a decimal number");
        Console.WriteLine("Input 3 to enter a word or sentence ");
        Console.Write("Please choose what ype of input youd like to make: ");
        num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.Write("Please enter an Integer: ");
                int @int=int.Parse(Console.ReadLine());
                Console.WriteLine("THe integer entered is "+@int);
                break;

            case 2:
                Console.Write("Please enter a decimal number: ");
                double @double = double.Parse(Console.ReadLine());
                Console.WriteLine("THe decimal number entered is "+@double);
                break;

            case 3:
                Console.Write("Please enter an Integer: ");
                string @string =Console.ReadLine();
                Console.WriteLine("The word or sentence you entered is; \"{0}\" ",@string);
                break;
        }
    }
}