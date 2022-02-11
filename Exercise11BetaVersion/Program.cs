class Exercise11betaVersion
{
    static void Main()
    {
        string one = " one"; string two = " two"; string three = " three"; string four = " four";
        string five = " five"; string six = " six"; string seven = " seven"; string eight = " eight";
        string nine = "nine"; string zero = " zero"; string ten = " ten"; string eleven = " eleven";
        string twelve = " twelve"; string thirteen = " thirteen"; string fourteen = " fourteen";
        string fifteen = " fifteen"; string sixteen = " sixteen"; string seventeen = " seventeen";
        string eighteen = " eighteen"; string nineteen = " nineteen";

        string twenty = " twenty"; string thirty = " thirty"; string fourty = " fourty"; string fifty = " fifty";
        string sixty = " sixty"; string seventy = " seventy"; string eighty = " eighty"; string ninety = " ninety";

        string hundred = "One Hundred and"; string hundred2 = "Two Hundred and"; string hundred3 = "Three Hundred and";
        string hundred4 = "Four Hundred and"; string hundred5 = "Five Hundred and"; string hundred6 = "Six Hundred and";
        string hundred7 = "Seven Hundred and"; string hundred8 = "Eight Hundred and"; string hundred9 = "Nine Hundred and";

        int lastDigit = 0; int secondDigit = 0; int firstDigit = 0; int num = 0;

        Console.Write("Please Enter A number from 0 to 999 : ");
        num = int.Parse(Console.ReadLine());
        lastDigit = num % 10; secondDigit = (num / 10) % 10; firstDigit = (num / 100) % 10;

        if (firstDigit != 0)
        {
            if (secondDigit == 0 && lastDigit == 0)
            {
                switch (firstDigit)
                {
                    case 1: Console.Write("The number in words is One Hundred"); break;

                    case 2: Console.Write("The number in words is Two Hundred"); break;

                    case 3: Console.Write("The number in words is Three Hundred"); break;

                    case 4: Console.Write("The number in words is Four Hundred"); break;

                    case 5: Console.Write("The number in words is Five Hundred"); break;

                    case 6: Console.Write("The number in words is Six Hundred"); break;

                    case 7: Console.Write("The number in words is Seven Hundred"); break;

                    case 8: Console.Write("The number in words is Eight Hundred"); break;

                    case 9: Console.Write("The number in words is Nine Hundred"); break;

                }
            }



            if (secondDigit != 0 || lastDigit != 0)
            {
                if (firstDigit == 1) { Console.Write("The number in words is " + hundred); }
                if (firstDigit == 2) { Console.Write("The number in words is " + hundred2); }
                if (firstDigit == 3) { Console.Write("The number in words is " + hundred3); }
                if (firstDigit == 4) { Console.Write("The number in words is " + hundred4); }
                if (firstDigit == 5) { Console.Write("The number in words is " + hundred5); }
                if (firstDigit == 6) { Console.Write("The number in words is " + hundred6); }
                if (firstDigit == 7) { Console.Write("The number in words is " + hundred7); }
                if (firstDigit == 8) { Console.Write("The number in words is " + hundred8); }
                if (firstDigit == 9) { Console.Write("The number in words is " + hundred9); }

                if (secondDigit != 1)
                {
                    if (secondDigit == 2) { Console.Write(twenty); }
                    if (secondDigit == 3) { Console.Write(thirty); }
                    if (secondDigit == 4) { Console.Write(fourty); }
                    if (secondDigit == 5) { Console.Write(fifty); }
                    if (secondDigit == 6) { Console.Write(sixty); }
                    if (secondDigit == 7) { Console.Write(seventy); }
                    if (secondDigit == 8) { Console.Write(eighty); }
                    if (secondDigit == 9) { Console.Write(ninety); }

                    if (lastDigit == 1) { Console.Write(one); }
                    if (lastDigit == 2) { Console.Write(two); }
                    if (lastDigit == 3) { Console.Write(three); }
                    if (lastDigit == 4) { Console.Write(four); }
                    if (lastDigit == 5) { Console.Write(five); }
                    if (lastDigit == 6) { Console.Write(six); }
                    if (lastDigit == 7) { Console.Write(seven); }
                    if (lastDigit == 8) { Console.Write(eight); }
                    if (lastDigit == 9) { Console.Write(nine); }
                }

                if (secondDigit == 1)
                {
                    switch (lastDigit)
                    {
                        case 0: Console.Write(ten); break;
                        case 1: Console.Write(eleven); break;
                        case 2: Console.Write(twelve); break;
                        case 3: Console.Write(thirteen); break;
                        case 4: Console.Write(fourteen); break;
                        case 5: Console.Write(fifteen); break;
                        case 6: Console.Write(sixteen); break;
                        case 7: Console.Write(seventeen); break;
                        case 8: Console.Write(eighteen); break;
                        case 9: Console.Write(nineteen); break;
                    }
                }
            }
        }

        if (firstDigit == 0)
        {
            if (secondDigit != 1)
            {
                if (secondDigit == 2) { Console.Write("The number in words is" + twenty); }
                if (secondDigit == 3) { Console.Write("The number in words is" + thirty); }
                if (secondDigit == 4) { Console.Write("The number in words is" + fourty); }
                if (secondDigit == 5) { Console.Write("The number in words is" + fifty); }
                if (secondDigit == 6) { Console.Write("The number in words is" + sixty); }
                if (secondDigit == 7) { Console.Write("The number in words is" + seventy); }
                if (secondDigit == 8) { Console.Write("The number in words is" + eighty); }
                if (secondDigit == 9) { Console.Write("The number in words is" + ninety); }

                if (lastDigit == 1) { Console.Write(one); }
                if (lastDigit == 2) { Console.Write(two); }
                if (lastDigit == 3) { Console.Write(three); }
                if (lastDigit == 4) { Console.Write(four); }
                if (lastDigit == 5) { Console.Write(five); }
                if (lastDigit == 6) { Console.Write(six); }
                if (lastDigit == 7) { Console.Write(seven); }
                if (lastDigit == 8) { Console.Write(eight); }
                if (lastDigit == 9) { Console.Write(nine); }
            }

            if (secondDigit == 1)
            {
                switch (lastDigit)
                {
                    case 0: Console.Write("The number in words is" + ten); break;
                    case 1: Console.Write("The number in words is" + eleven); break;
                    case 2: Console.Write("The number in words is" + twelve); break;
                    case 3: Console.Write("The number in words is" + thirteen); break;
                    case 4: Console.Write("The number in words is" + fourteen); break;
                    case 5: Console.Write("The number in words is" + fifteen); break;
                    case 6: Console.Write("The number in words is" + sixteen); break;
                    case 7: Console.Write("The number in words is" + seventeen); break;
                    case 8: Console.Write("The number in words is" + eighteen); break;
                    case 9: Console.Write("The number in words is" + nineteen); break;
                }
            }

            if (secondDigit == 0)
            {
                if (lastDigit == 0) { Console.Write("The number in words is" + zero); }
                if (lastDigit == 1) { Console.Write("The number in words is" + one); }
                if (lastDigit == 2) { Console.Write("The number in words is" + two); }
                if (lastDigit == 3) { Console.Write("The number in words is" + three); }
                if (lastDigit == 4) { Console.Write("The number in words is" + four); }
                if (lastDigit == 5) { Console.Write("The number in words is" + five); }
                if (lastDigit == 6) { Console.Write("The number in words is" + six); }
                if (lastDigit == 7) { Console.Write("The number in words is" + seven); }
                if (lastDigit == 8) { Console.Write("The number in words is" + eight); }
                if (lastDigit == 9) { Console.Write("The number in words is" + nine); }
            }
        }

    }
}