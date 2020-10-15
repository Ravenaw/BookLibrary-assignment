using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookProject;

namespace BookTest
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void CorrectData()
        {
            //Assign
            Book book;

            //Act
            book = new Book("The Book", "Anyone", 50, "1234567891234");

            //Assert
            Assert.IsNotNull(book);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IncorrectPage()
        {
            //Assign
            Book book;

            //Act
            book = new Book("The Book", "Anyone", 5, "1234567891234");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IncorrectTitle()
        {
            //Assign
            Book book;

            //Act
            book = new Book("T", "Anyone", 50, "1234567891234");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IncorrectIsbn()
        {
            //Assign
            Book book;

            //Act
            book = new Book("The Book", "Anyone", 50, "123456789123");
        }

        [TestMethod]
        public void CorrectSet()
        {
            //Assign
            Book book = new Book("The Book", "Anyone", 50, "1234567891234");

            //Act
            book.Title = "The Other Book";
            book.Author = "Someone";
            book.PageAmount = 100;
            book.Isbn = "9876543219876";

            //Assert
            Assert.AreEqual(book.Title, "The Other Book");
            Assert.AreEqual(book.Author, "Someone");
            Assert.AreEqual(book.PageAmount, 100);
            Assert.AreEqual(book.Isbn, "9876543219876");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IncorrectTitleSet()
        {
            //Assign
            Book book = new Book("The Book", "Anyone", 50, "1234567891234");

            //Act
            book.Title = "A";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IncorrectPageAmountSet()
        {
            //Assign
            Book book = new Book("The Book", "Anyone", 50, "1234567891234");

            //Act
            book.PageAmount = 2000;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IncorrectIsbnSet()
        {
            //Assign
            Book book = new Book("The Book", "Anyone", 50, "1234567891234");

            //Act
            book.Isbn = "123456789123";
        }
    }
}
