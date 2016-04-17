using RestApiSQL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestApiSQL.DAL
{
    public class StoreInitializer : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var books = new List<Book>
            {
                new Book() { Id = 1, ISBN = "asd", Title = "Book1" },
                new Book() { Id = 2, ISBN = "dsa", Title = "Book2" }
            };
            context.Books.AddRange(books);
            context.SaveChanges();

            var authors = new List<Author>
            {
                new Author() { Id = 1, Name = "Name1", Surname = "Surname1" },
                new Author() { Id = 2, Name = "name2", Surname = "surname2" }
            };
            context.Authors.AddRange(authors);
            context.SaveChanges();
        }
    }
}