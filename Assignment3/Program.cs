using Microsoft.VisualBasic;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?

            //Book book = new Book();
            //Console.WriteLine(book.password);
            // not show the variable passowrd because it private
            // private means show only inside the class


            #endregion

            #region Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ?

            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);
            // the value of copiesInStock show in console because it internal
            // internal means show in the same assemply


            #endregion

           

        }
    }
}
