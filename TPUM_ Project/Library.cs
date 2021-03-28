using System;
using System.Collections.Generic;
using System.Text;
namespace TPUM__Project
{
    class Library
    {
        private int amountOfBooks;
        public Library(int amountOfBooks)
        {
            this.amountOfBooks = amountOfBooks;
        }
        public bool checkAmountOfBook(int books)
        {
            if(books == amountOfBooks)
            {
                return true;
            }
            return false;
        }
    }
}
