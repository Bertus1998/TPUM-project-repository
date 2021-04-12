using Projekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Library_Client
{
    class Book : IBook
    {
        private int id;
        private string title;
        //status == true if book is available
        private bool status;
        private  Image cover;

        public bool changeStatus()
        {
            throw new NotImplementedException();
        }

        public bool checkStatus()
        {
            throw new NotImplementedException();
        }
    }
}
