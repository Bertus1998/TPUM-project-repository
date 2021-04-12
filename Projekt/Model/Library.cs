using Projekt.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Client
{
    class Library: ILibrary
    {
        private Hashtable openWith = new Hashtable();

        public bool addBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool removeBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
    
}
