using System;

static void plusMinus(List<int> arr)
{
    double nTotal = 0;
    double positive = 0;
    double negative = 0;
    double zero = 0;

    foreach (int number in arr)
    {
        if (number > 0)
        {
            positive++;
        }
        else if (number == 0)
        {
            zero++;
        }
        else
        {
            negative++;
        }

        nTotal++;
    }

    Console.WriteLine($"{(positive / nTotal).ToString("F6")}");
    Console.WriteLine($"{(negative / nTotal).ToString("F6")}");
    Console.WriteLine($"{(zero / nTotal).ToString("F6")}");

}

static void Main()
{

}