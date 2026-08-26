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

            #region Add a public string Title; field to Book. Set it and print it from Main.

            //Book book = new Book();
            //Console.WriteLine(book.Title);
            // the value of Title show in console because it public
            // public means show in everywhere

            #endregion

            #region Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.

            //Book book = new Book();
            //Console.WriteLine(book.genre);


            #endregion

            #region Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.

            //Genre genre01 = Genre.Fiction;
            //Genre genre02 = Genre.NonFiction;
            //Genre genre03 = Genre.Science;
            //Console.WriteLine((int)genre01);
            //Console.WriteLine((int)genre02);
            //Console.WriteLine((int)genre03);

            #endregion

            
           

        }
    }
}
