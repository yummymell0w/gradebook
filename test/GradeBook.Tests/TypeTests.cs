using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            Assert.Equal("", book1.Name);
            Assert.Equal("", book2.Name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
