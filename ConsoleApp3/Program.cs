using System.Text;

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
            #region Question 2-2
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(book1));
            Console.WriteLine(book1.GetHashCode()); 
            Console.WriteLine(book1.GetType());
            #endregion

            #endregion
            #region question 2-3
            Book book2 = new Book();
            book2.Title = "book2 Name";
            book2.Pages = 350;
            object y = book2;
            Console.WriteLine(y);
            Console.WriteLine(book1.Equals(book2));
            #endregion
            #region Question 3
            try
            {
                int a = 10;
                int b = 0;
                int Result = a / b;
                //Console.WriteLine(Result);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("Done");
            }
            #endregion

            #region Question 4
            double Pages = book1.Pages ;
            #endregion


        }

        class Book
        { 
            #region Question 1-2
            public string Title;
            public int Pages;
            #endregion
            #region Question 2-1
            public override string ToString()
            {
                return $"Title :{Title}, Pages :{Pages}";
            }
            #endregion
        }
    }
}