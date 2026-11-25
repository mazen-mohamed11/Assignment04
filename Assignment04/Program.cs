using System;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Q1
            Book book01 = new Book();
            /* Console.WriteLine(book01.password);*/ // will happen compile-time error because we declared password with private access modifier and it is work within the same class only.
            Console.WriteLine("-----------------------------------");
            #endregion
            #region
            //Q2
            Console.WriteLine(book01.copiesInStock); // it is working because internal access modifier work within the same assembly.
            Console.WriteLine("-----------------------------------");
            #endregion
            #region
            //Q3
            Console.WriteLine(book01.title);
            Console.WriteLine("-----------------------------------");
            #endregion
            #region
            //Q4
            Genre item01 = Genre.Science;
            Console.WriteLine(item01);
            Console.WriteLine("-----------------------------------");
            #endregion
            #region
            //Q5
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            Console.WriteLine("-----------------------------------");
            #endregion
            #region
            //Q6
            int genreNumber = 1;
            Console.WriteLine((Genre)genreNumber);
            Console.WriteLine("-----------------------------------");
            #endregion
            #region
            //Q7
            Genre genre = Genre.Fiction;
            genre.ToString();
            Console.WriteLine(genre);
            Console.WriteLine("-----------------------------------");
            #endregion
            #region
            //Q8
            string genreText = "Science";
            Genre genre02 = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(genre02);
            Console.WriteLine("-----------------------------------");
            #endregion
            #region
            //Q9
            string genreText02 = "Mystery";
            if(Enum.TryParse(genreText02,out Genre genre03))
            {
                Console.WriteLine(genre03);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            Console.WriteLine("-----------------------------------");
            #endregion
        }
    }
}
