class Exercise9
{
    static void Main()
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        Console.Write("Please enter a number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number: ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number: ");
        num3 = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number: ");
        num4 = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number: ");
        num5 = int.Parse(Console.ReadLine());

        //subsets of two
        if (num1 + num2 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num2 + "}");
        }
        if (num1 + num3 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num3 + "}");
        }
        if (num1 + num4 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num4 + "}");
        }
        if (num1 + num5 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num5 + "}");
        }

        if (num2 + num3 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num3 + "}");
        }
        if (num2 + num4 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num4 + "}");
        }
        if (num2 + num5 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num5 + "}");
        }

        if (num3 + num4 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num4 + "}");
        }
        if (num3 + num5 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num5 + "}");
        }

        if (num4 + num5 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num5 + "}");
        }

        //subsets of three
        if (num1 + num2 + num3 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num2 + "," + num3 + "}");
        }
        if (num1 + num2 + num4 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num2 + "," + num4 + "}");
        }
        if (num1 + num2 + num5 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num2 + "," + num5 + "}");
        }
        if (num1 + num3 + num4 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num3 + "," + num4 + "}");
        }
        if (num1 + num3 + num5 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num2 + "," + num3 + "}");
        }
        if (num1 + num4 + num5 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num2 + "," + num3 + "}");
        }
        if (num2 + num3 + num4 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num3 + "," + num4 + "}");
        }
        if (num2 + num3 + num5 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num3 + "," + num5 + "}");
        }
        if (num2 + num4 + num5 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num4 + "," + num5 + "}");
        }
        if (num3 + num4 + num5 == 0)
        {
            Console.WriteLine("{" + num3 + "," + num4 + "," + num5 + "}");
        }

        //subsets of four
        if (num1 + num2 + num3 + num4 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num2 + "," + num3 + "," + num4 + "}");
        }
        if (num1 + num2 + num3 + num5 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num2 + "," + num3 + "," + num4 + "}");
            if (num1 + num3 + num4 + num5 == 0)
            {
                Console.WriteLine("{" + num1 + "," + num3 + "," + num4 + "," + num5 + "}");
            }
        }
        if (num2 + num3 + num4 + num5 == 0)
        {
            Console.WriteLine("{" + num2 + "," + num3 + "," + num4 + "," + num5 + "}");
        }
        if (num1 + num2 + num3 + num4 + num5 == 0)
        {
            Console.WriteLine("{" + num1 + "," + num2 + "," + num3 + "," + num4 + "," + num5 + "}");
        }

        Console.WriteLine("\n\n\nIf no subsets are displayed above, then," +
            " the numbers entered do not have any subsets that can be added to give zero");


    }
}
