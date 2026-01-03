using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystemInterfaces
{
    public interface IReservable
    {
        public void Reserve();
    }

    public interface INotifiable 
    {
        public void Notify();   

    }
}
