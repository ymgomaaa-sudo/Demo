namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "book Name";
            object x = (string)book1.Title;
        }
        class Book
        {
            public string Title;
            public int Pages;
        }
    }
}