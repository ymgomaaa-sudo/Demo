namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Book book1 = new Book();
            book1.Title = "book Name";
            book1.Pages = 300;
            object x = book1;
            Console.WriteLine(x);
            #endregion
        }
        class Book
        {
            public string Title;
            public int Pages;
            
        }
    }
}