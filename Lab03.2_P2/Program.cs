using Lab03._2_P2;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book = new Book();
        book.Display();
        int i = 0;
        book.flipPageForward();

        book.flipPageBackward();
    }
}