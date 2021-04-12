using Library_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    interface ILibrary
    {
        bool addBook(Book book);
        bool removeBook(Book book);
    }
}
