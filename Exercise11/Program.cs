class Exercise11
{
    static void Main()
    {
        int num1 = 0;   string one = "-one";        string six = "-six";
        int num2 = 0;   string two = "-two";        string seven = "-seven";
        int num3 = 0;   string three = "-three";    string eight = "-eight";
        int num4 = 0;   string four = "-four";      string nine = "-nine";
        int num5 = 0;   string five = "five";
        Console.Write("Please enter a number from 0 to 99: ");
        int num=int.Parse(Console.ReadLine());
        if (num >= 0 && num <= 9)
        {
            switch (num)
            {
                case 0: Console.Write("The number in words is Zero");break;

                case 1: Console.Write("The number in words is one"); break;

                case 2: Console.Write("The number in words is two"); break;

                case 3: Console.Write("The number in words is three"); break;

                case 4: Console.Write("The number in words is four"); break;

                case 5: Console.Write("The number in words is five"); break;

                case 6: Console.Write("The number in words is six"); break;

                case 7: Console.Write("The number in words is seven"); break;

                case 8: Console.Write("The number in words is eight"); break;

                case 9: Console.Write("The number in words is nine"); break;

                
            }
        }

        if (num >= 10 && num <= 19)
        {
            num1 = num % 10;
            switch (num1)
            {
                case 0:Console.Write("THe number in words is ten");break;

                case 1: Console.Write("THe number in words is eleven"); break;

                case 2: Console.Write("THe number in words is twelve"); break;

                case 3: Console.Write("THe number in words is thirteen"); break;

                case 4: Console.Write("THe number in words is fourteen"); break;

                case 5: Console.Write("THe number in words is fifteen"); break;

                case 6: Console.Write("THe number in words is sixteen"); break;

                case 7: Console.Write("THe number in words is seventeen"); break;

                case 8: Console.Write("THe number in words is eighteen"); break;

                case 9: Console.Write("THe number in words is nineteen"); break;


            }
        }

        if(num >= 20 && num <= 29)
        {
            num2 = num%10;
            switch (num2)
            {
                case 0: Console.Write("The number in words is twenty");break;

                case 1:Console.Write("The number in words is twenty" + one);break;

                case 2: Console.Write("The number in words is twenty" + two); break;

                case 3: Console.Write("The number in words is twenty" + three); break;

                case 4: Console.Write("The number in words is twenty" + four); break;

                case 5: Console.Write("The number in words is twenty" + five); break;

                case 6: Console.Write("The number in words is twenty" + six); break;

                case 7: Console.Write("The number in words is twenty" + seven); break;

                case 8: Console.Write("The number in words is twenty" + eight); break;

                case 9: Console.Write("The number in words is twenty" + nine); break;


            }
        }

        if (num >= 30 && num <= 39)
        {
            num3 = num % 10;
            switch (num3)
            {
                case 0: Console.Write("The number in words is Thirty"); break;

                case 1: Console.Write("The number in words is Thirty" + one); break;

                case 2: Console.Write("The number in words is Thirty" + two); break;

                case 3: Console.Write("The number in words is Thirty" + three); break;

                case 4: Console.Write("The number in words is Thirty" + four); break;

                case 5: Console.Write("The number in words is Thirty" + five); break;

                case 6: Console.Write("The number in words is Thirty" + six); break;

                case 7: Console.Write("The number in words is Thirty" + seven); break;

                case 8: Console.Write("The number in words is Thirty" + eight); break;

                case 9: Console.Write("The number in words is Thirty" + nine); break;


            }
        }



    }
}