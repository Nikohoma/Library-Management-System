using LibraryManagement;


namespace MainClass;

public class LMS
{
    public static void Main()
    {
        #region Instances
        /// Books 
        var title = "Story of my Life"; var author = "Anne Frank"; var id = 1; var daysLate = 0;
        Book book1 = new Book(title, author, id, daysLate);
        book1.ItemDetails();
        var output = book1.LateFee();
        Console.Write("\nLate Fees: ");
        Console.WriteLine(output);
        Console.WriteLine();


        /// Magazine
        var Mtitle = "30 under 30"; var Mauthor = "Forbes"; var Mid = 2; var MdaysLate = 4;
        Magazine magazine1 = new Magazine(Mtitle, Mauthor, Mid, MdaysLate);
        magazine1.ItemDetails();   
        var output1 = magazine1.LateFee();
        Console.Write("\nLate Fees: ");
        Console.WriteLine(output1);
        Console.WriteLine();

        #endregion
    }
}