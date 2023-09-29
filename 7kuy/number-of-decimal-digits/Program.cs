using System;
using System.Text;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main(string[] args)
    {
        var result = Digits(999);

        Console.WriteLine(result);
    }

    public static int Digits(ulong n)
    {
        return n.ToString().Length;
    }
}