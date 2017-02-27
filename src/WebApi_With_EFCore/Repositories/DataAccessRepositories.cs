using System.Collections.Generic;
using System.Linq;
using WebApi_With_EFCore.Models;

namespace WebApi_With_EFCore.Repositories
{
    public interface IDataAccess<TEntity,U> where TEntity : class
    {
        IEnumerable<TEntity> GetBooks();
        TEntity GetBook(U id);
        int AddBook(TEntity b);
        int UpdateBook(U id,TEntity b);
        int DeleteBook(U id); 
    }

    public class DataAccessRepository : IDataAccess<Book, int>
    {
        ApplicationContext ctx;
        public DataAccessRepository(ApplicationContext c)
        {
            ctx = c;
        }
        public int AddBook(Book b)
        {
            ctx.Books.Add(b);
            int res = ctx.SaveChanges();
            return res;
        }

        public int DeleteBook(int id)
        {
            int res = 0;
            var book = ctx.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                ctx.Books.Remove(book);
                res = ctx.SaveChanges();
            }
            return res;
        }

        public Book GetBook(int id)
        {
            var book = ctx.Books.FirstOrDefault(b=>b.Id==id);
            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            var books = ctx.Books.ToList();
            return books;
        }

        public int UpdateBook(int id,Book b)
        {
            int res = 0;
            var book = ctx.Books.Find(id);
            if (book != null)
            {
                book.BookTitle = b.BookTitle;
                book.AuthorName = b.AuthorName;
                book.Publisher = b.Publisher;
                book.Genre = b.Genre;
                book.Price = b.Price; 
               res = ctx.SaveChanges();
            }
            return res;
        }
    }
}
