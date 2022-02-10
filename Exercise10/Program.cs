class Exercise10
{
    static void Main()
    {
        Console.Write("Please enter your score between 1 and 9 to receive your bonus marks: ");
        float score=float.Parse(Console.ReadLine());

        if (0 < score && score < 10)
        {
            if (score >= 1 && score <= 3)
            {
                score *= 10;
                Console.WriteLine("Your final score is " + score);
            }
            if (score >= 4 && score <= 6)
            {
                score *= 100;
                Console.WriteLine("Your final score is " + score);
            }
            if (score >= 7 && score <= 9)
            {
                score *= 1000;
                Console.WriteLine("Your final score is " + score);
            }
        }
        else
        {
            Console.WriteLine("Don't be cheeky, enter a score in the specified range");
        }
    }
}