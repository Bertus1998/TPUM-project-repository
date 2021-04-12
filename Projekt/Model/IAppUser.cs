using Library_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    interface IAppUser
    { 
        void logOut(string name, string password);
        void logIn(string name, string password);
        List<Library_Client.Book> getUserBook();
        void borrowBook(Book book);
        void returnBook(Book book);
    }
}
