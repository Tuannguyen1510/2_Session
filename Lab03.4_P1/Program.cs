using Lab03._4_P1;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 20, b = 30;
        double area;
        Utility utility = new Utility();

        Console.WriteLine("truoc khi hoan vị a={0}, b={1}", a, b);
        utility.SwapFake(a, b);
        Console.WriteLine("sau khi hoan vị fake a={0}, b={1}", a, b);

        utility.SwapReally(ref a, ref b);
        Console.WriteLine("sau khi hoan vị really a={0}, b={1}", a, b);

        utility.AreaCircle(a, out area);
        Console.WriteLine("Chu vi hinh tron ban kinh 100: {0}", area);

    }
}