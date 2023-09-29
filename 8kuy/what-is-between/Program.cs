using System.Text.RegularExpressions;
using System.Text;

public class StartUp
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        var result = Between(1, 5);

        foreach (var num in result)
        {
            sb.Append(num + " ");
        }

        Console.WriteLine(sb.ToString().TrimEnd());
    }

    public static int[] Between(int a, int b)
    {
        List<int> lst = new List<int>();

        for (int i = a; i <= b; i++)
        {
            lst.Add(i);
        }

        return lst.ToArray();
    }
}