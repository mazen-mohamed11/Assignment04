using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment04
{
    public class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string title = "Datastructure";
    }
    public enum Genre
    {
        Fiction,
        NonFiction,
        Science
    };
}
