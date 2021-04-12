using Library_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class AppUse : IAppUser
    {
        private bool status;
        private string password;
        private string name;

        public void borrowBook(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> getUserBook()
        {
            throw new NotImplementedException();
        }

        public void logIn(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void logOut(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void returnBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
