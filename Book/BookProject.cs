using System;
using System.Net;

namespace BookProject
{
    /// <summary>
    /// Book class library.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Title property with rule abiding set function.
        /// </summary>
        public string Title
        {
            get
            {
                return Title;
            }
            set
            {
                Title = value.Length >= 2 ? value : throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Author property.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Page amount property with rule abiding set function.
        /// </summary>
        public int PageAmount
        {
            get
            {
                return PageAmount;
            }
            set
            {
                PageAmount = value > 10 && value < 1000 ? value : throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// ISBN number property with rule abiding set function.
        /// </summary>
        public string Isbn
        {
            get
            {
                return Isbn;
            }
            set
            {
                Isbn = value.Length == 13 ? value : throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// This is the parametric constructor for the Book class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="pageAmount"></param>
        /// <param name="isbn"></param>
        public Book(string title, string author, int pageAmount, string isbn)
        {
            Title = title.Length >= 2 ? title : throw new ArgumentOutOfRangeException();
            Author = author;
            PageAmount = pageAmount > 10 && pageAmount < 1000 ? pageAmount : throw new ArgumentOutOfRangeException();
            Isbn = isbn.Length == 13 ? isbn : throw new ArgumentOutOfRangeException();
        }
    }
}
