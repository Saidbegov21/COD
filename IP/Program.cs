internal class NewBaseType
{
    private static void Main(string[] args)
    {
        int sum (int m, int n)
        {
            int start = m;
            int end = n;
            if (m > n)
            {
                start = n;
                end = m;
            }
            return (end + start) * (end - start + 1) / 2; //Формула
        }

        Console.WriteLine(sum(72, 16));
    }
}

internal class Program : NewBaseType
{
}