using System;

public class NewBaseType
{
    public static void Main()
    {
        int t (int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return t (m - 1, 1);
            }
            return t (m - 1, t(m, n - 1));
        }
        Console.WriteLine(t (3, 2));
    }
}

public class Program : NewBaseType
{
}