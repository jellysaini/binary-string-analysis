
using System;


public class Program
{
    public static void Main()
    {
        string test1 = "1010";
        string test2 = "1001";
        string test3 = "111000";
        string test4 = "11001100";
        string test5 = "21100";


        Console.WriteLine($"{test1} is {AnalyzeBinaryString(test1)} string");
        Console.WriteLine($"{test2} is {AnalyzeBinaryString(test2)} string");
        Console.WriteLine($"{test3} is {AnalyzeBinaryString(test3)} string");
        Console.WriteLine($"{test4} is {AnalyzeBinaryString(test4)} string");
        Console.WriteLine($"{test5} is {AnalyzeBinaryString(test5)} string");
    }

    public static string AnalyzeBinaryString(string binaryString)
    {
        int onesCount = 0;
        int zerosCount = 0;

        foreach (char ch in binaryString)
        {
            // If the string contains characters other than '0' or '1' then it return
            if (ch != '0' && ch != '1')
            {
                return "invalid input"; 
            }

            if (ch == '1')
            {
                onesCount++;
            }
            else if (ch == '0')
            {
                zerosCount++;
            }

            //If the number of zeros exceeds 1, it's not good
            if (zerosCount > onesCount)
            {
                return "not good";
            }
        }

        //If the total number of 1's and 0's are equal
        return onesCount == zerosCount ? "good" : "not good";
    }
}
