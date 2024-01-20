using LibraryManagement.DTO;
using LibraryManagement.Data;
using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class TestService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public TestService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void Test()
        {
            BookModel harryPottah = new BookModel(1, "Harry Pottah");
            applicationDbContext.Books.Add(harryPottah);

            BookModel harryPottah2 = new BookModel(2, "Harry Pottah 2");
            applicationDbContext.Books.Add(harryPottah2);

            BookModel harryPottah3 = new BookModel(3, "Harry Pottah 3");
            applicationDbContext.Books.Add(harryPottah3);

            BookModel harryPottah4 = new BookModel(4, "Harry Pottah 4");
            applicationDbContext.Books.Add(harryPottah4);

            BookModel harryPottah5 = new BookModel(5, "Harry Pottah 5");
            applicationDbContext.Books.Add(harryPottah5);

            BookModel harryPottah6 = new BookModel(6, "Harry Pottah 6");
            applicationDbContext.Books.Add(harryPottah6);

            BookModel harryPottah7 = new BookModel(7, "Harry Pottah 7");
            applicationDbContext.Books.Add(harryPottah7);

            BookModel harryPottah8 = new BookModel(8, "Harry Pottah 8");
            applicationDbContext.Books.Add(harryPottah8);

            BookModel harryPottah9 = new BookModel(9, "Harry Pottah 9");
            applicationDbContext.Books.Add(harryPottah9);

            BookModel harryPottah10 = new BookModel(10, "Harry Pottah 10");
            applicationDbContext.Books.Add(harryPottah10);

            BookModel harryPottah11 = new BookModel(11, "Harry Pottah 11");
            applicationDbContext.Books.Add(harryPottah11);

            BookModel harryPottah12 = new BookModel(12, "Harry Pottah 12");
            applicationDbContext.Books.Add(harryPottah12);

            BookModel harryPottah13 = new BookModel(13, "Harry Pottah 13");
            applicationDbContext.Books.Add(harryPottah13);

            applicationDbContext.SaveChanges();
        }
    }
}