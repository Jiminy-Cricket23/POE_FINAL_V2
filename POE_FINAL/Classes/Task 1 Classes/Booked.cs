using POE_FINAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicPOE.Classes
{
    /// <summary>
    /// This object is used so that the reference number can be sorted first and then the author name
    /// Use this object To generate everything
    /// </summary>
    internal class Booked
    {
        /// <summary>
        /// The generation is done in the construction, this generates all the random books needed to be sorted in the game
        /// </summary>
        /// <param name="referenceNumber"></param>
        /// <param name="authorName"></param>
        public frmSortingGame.Book GenBook(Random rnd)
        {
            // Generation adapted from: https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
            // Randomising using code from: https://www.codegrepper.com/code-examples/csharp/how+to+generate+random+letters+in+C%23

            frmSortingGame.Book book = new frmSortingGame.Book();
            string Ref = rnd.Next(0, 999).ToString();
            // formatting the second number correctly
            int second = rnd.Next(0, 999);
            if (second < 10)
                Ref += ".00" + second.ToString();
            else if (second < 100 && second > 9)
                Ref += ".0" + second.ToString();
            else
                Ref += "." + second.ToString();

            book.ReferenceNumber = double.Parse(Ref); // Generates a random Number

            //Random Author's name 
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            book.AuthorName = "";
            for (int j = 0; j < 3; j++)
            {
                book.AuthorName += chars[rnd.Next(0, chars.Length)];
            }

            book.Unicode = double.Parse(book.ReferenceNumber.ToString() + UnicodeConversion(book.AuthorName).ToString()); // this needs to be like it so that it attacks the reference number first

            return book;
        }

        /// <summary>
        /// This gets the string value of a book with the inlcuded processing it needs to be displayed properly
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        internal string StringValue(frmSortingGame.Book book)
        {
            string sLine = "";
            if (book.ReferenceNumber > 100)
                sLine = book.ReferenceNumber.ToString();
            else if (book.ReferenceNumber < 10)
                sLine = "00" + book.ReferenceNumber.ToString();
            else
                sLine = "0" + book.ReferenceNumber.ToString();
            //if (book.ReferenceNumber < 100 && book.ReferenceNumber >9)
             
            if (sLine.Length < 7)
                sLine += "0";

            return sLine + " " + book.AuthorName;
        }
        /// <summary>
        /// (Now has a capital letter) this does the conversion of the string to the unicode so that it can be effectively sorted
        /// </summary>
        /// <param name="Author"></param>
        /// <returns></returns>
         public double UnicodeConversion(string Author)
         {
            double uni;
            string auth = "";

            foreach(char c in Author)
            {
                int unicode = c;
                auth += unicode.ToString();
            }
            uni = double.Parse(auth);
            return uni;
         }
    }
}
