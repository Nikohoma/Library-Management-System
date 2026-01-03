using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystemInterfaces
{
    public interface IReservable
    {
        public void Reserve(string title);
    }

    public interface INotifiable 
    {
        public void Notify(string title);   

    }
}
