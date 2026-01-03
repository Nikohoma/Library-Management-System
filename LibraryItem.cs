using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagementSystemInterfaces;

namespace LibraryManagement;


public abstract class LibraryItem
{
    #region Properties
    public string Title { get; protected set; }
    public string Author { get; protected set; }
    public int ItemId { get; protected set; } 
    public int DaysLate { get; protected set; }

    public List <LibraryItem> libraryItems = new List<LibraryItem>(); 

    #endregion


    #region Abstract Methods

    public abstract void ItemDetails();

    public abstract double LateFee();

    #endregion



}

/// <summary>
/// Book Class inheriting LibraryItem and implementing INotifiable and IReservable interfaces
/// </summary>
public class Book : LibraryItem, INotifiable, IReservable
{

    #region Constructor
    public Book(string title, string author, int id, int daysLate)
    {
        Title = title;
        Author = author;
        ItemId = id;
        DaysLate = daysLate;
    }

    #endregion


    #region Overriding Methods
    public override void ItemDetails()
    {
        Console.WriteLine($"Book Details\nId : {ItemId}, Title : {Title}, Author: {Author}\n");
    }

    public override double LateFee()
    {
        return DaysLate*1;
    }

    #endregion

    #region Interfaces Execution

    public void Reserve() 
    {
        Console.WriteLine($"\n'{Title}' is reserved successfully.");
    }

    public void Notify()
    {
        Console.WriteLine($"Notification Sent: '{Title}' is ready for pickup.");
    }

    #endregion


}

public class Magazine : LibraryItem
{
    #region Constructor
    public Magazine(string title, string author, int id, int daysLate)
    {
        Title = title;
        Author = author;
        ItemId = id;
        DaysLate = daysLate;
    }
    #endregion


    #region Override Methods
    public override void ItemDetails() 
    {
        Console.WriteLine($"\nMagazine Details\nId : {ItemId}, Title : {Title}, Author: {Author}\n");
    }

    public override double LateFee()
    {
        return DaysLate * 0.5;
    }

    #endregion

    #region Interfaces Execution
    public void Reserve()
    {
        Console.WriteLine($"'{Title}' reserved successfully.");
    }

    public void Notify()
    {
        Console.WriteLine($"Notification Sent: '{Title}' is ready for pickup.");
    }

    #endregion

}
