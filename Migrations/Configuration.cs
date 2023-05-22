namespace WinFormsApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WinFormsApp1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WinFormsApp1.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WinFormsApp1.AppContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WinFormsApp1.AppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Admins.AddOrUpdate(new Models.Admin()
            {
                UserName = "admin",
                Password = "123456"
            });
            context.Admins.AddOrUpdate(new Models.Admin()
            {
                UserName = "a",
                Password = "a"
            });

            Category category = new Category() 
            {
                Name = "math",
            };
            context.Categories.AddOrUpdate(category);

            List<Book> books = new List<Book>();
            books.Add(new Book()
            {
                Title = "aa",
                Author = "aaa",
                AvailableCopies = 1,
                Description = "aaaaaaaaaaaaa",
                ISBN = "978-3-16-148410-0",
                TotalCopies = 1,
                PathOfImage = "aaaaaaaa",
                Category = category
            });
            books.Add(new Book()
            {
                Title = "bb",
                Author = "bbb",
                AvailableCopies = 1,
                Description = "bbbbbbbbbbbbbbbbbbb",
                ISBN = "978-3-16-148410-0",
                TotalCopies = 1,
                PathOfImage = "bbbbbbbbbbbbb",
                Category = category
            });
            books.Add(new Book()
            {
                Title = "cc",
                Author = "ccc",
                AvailableCopies = 1,
                Description = "cccccccccccccccccccc",
                ISBN = "978-3-16-148410-0",
                TotalCopies = 1,
                PathOfImage = "ccccccccc",
                Category = category
            });
            context.Books.AddRange(books);

            base.Seed(context);
        }
    }
}
