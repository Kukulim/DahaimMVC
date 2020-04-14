using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.Models
{
    public class StoreDbInitializer : CreateDatabaseIfNotExists<StoreDbContext>
    {
        protected override void Seed(StoreDbContext context)
        {
            context.Authors.Add(new Author { AuthorId = 1, AuthorName = "Łucja Bekus" });

            context.Types.Add(new Type { TypeId = 1, Name = "E-Book" });
            context.Types.Add(new Type { TypeId = 2, Name = "Kurs" });
            context.Types.Add(new Type { TypeId = 3, Name = "Książka" });

            //E-booki

            context.Products.Add(new Product { ProductId = 1, TypeId = 1, AuthorId = 1, Price = 130, Title = "Niemiecki Podstawy", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 2, TypeId = 1, AuthorId = 1, Price = 50, Title = "Niemiecki Podstawy cz.1", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 3, TypeId = 1, AuthorId = 1, Price = 55, Title = "Niemiecki Podstawy cz.2", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 4, TypeId = 1, AuthorId = 1, Price = 50, Title = "Niemiecki Gramatyka cz.1", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 5, TypeId = 1, AuthorId = 1, Price = 55, Title = "Niemiecki Gramatyka cz.2", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 6, TypeId = 1, AuthorId = 1, Price = 55, Title = "Niemiecki Gramatyka cz.3", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 7, TypeId = 1, AuthorId = 1, Price = 55, Title = "Niemiecki Nie gryzie! cz.1", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 8, TypeId = 1, AuthorId = 1, Price = 52, Title = "Niemiecki Nie gryzie! cz.2", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 9, TypeId = 1, AuthorId = 1, Price = 55, Title = "Niemiecki Nie gryzie! cz.3", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 10, TypeId = 1, AuthorId = 1, Price = 45, Title = "Niemiecki Rozmowki", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 11, TypeId = 1, AuthorId = 1, Price = 44, Title = "Niemiecki od podstaw", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 12, TypeId = 1, AuthorId = 1, Price = 22, Title = "Niemiecki dla studenta cz.1", ProductArtUrl = "/content/images/ebook.jpg" });
            context.Products.Add(new Product { ProductId = 13, TypeId = 1, AuthorId = 1, Price = 55, Title = "Niemiecki dla studenta cz.1", ProductArtUrl = "/content/images/ebook.jpg" });

            //Kursy

            context.Products.Add(new Product { ProductId = 14, TypeId = 2, AuthorId = 1, Price = 600, Title = "Kurs - Niemiecki Podstawy", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 15, TypeId = 2, AuthorId = 1, Price = 700, Title = "Kurs - Niemiecki Podstawy cz.2", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 16, TypeId = 2, AuthorId = 1, Price = 700, Title = "Kurs - Semeste I", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 17, TypeId = 2, AuthorId = 1, Price = 600, Title = "Kurs - Semeste II", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 18, TypeId = 2, AuthorId = 1, Price = 600, Title = "Kurs - Semeste III", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 19, TypeId = 2, AuthorId = 1, Price = 600, Title = "Kurs - Semeste IV", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 20, TypeId = 2, AuthorId = 1, Price = 600, Title = "Kurs - Semeste V", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 21, TypeId = 2, AuthorId = 1, Price = 400, Title = "Kurs - rok - A0", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 22, TypeId = 2, AuthorId = 1, Price = 670, Title = "Kurs - rok - A1", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 23, TypeId = 2, AuthorId = 1, Price = 670, Title = "Kurs - rok - A2", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 24, TypeId = 2, AuthorId = 1, Price = 888, Title = "Kurs - rok - B1", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 25, TypeId = 2, AuthorId = 1, Price = 888, Title = "Kurs - rok - B2", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 26, TypeId = 2, AuthorId = 1, Price = 999, Title = "Kurs - rok - C1", ProductArtUrl = "/content/images/kurs.jpg" });
            context.Products.Add(new Product { ProductId = 27, TypeId = 2, AuthorId = 1, Price = 999, Title = "Kurs - rok - C2", ProductArtUrl = "/content/images/kurs.jpg" });

            //Książki

            context.Products.Add(new Product { ProductId = 28, TypeId = 3, AuthorId = 1, Price = 130, Title = "Niemiecki Podstawy", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 29, TypeId = 3, AuthorId = 1, Price = 50, Title = "Niemiecki Podstawy cz.1", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 30, TypeId = 3, AuthorId = 1, Price = 55, Title = "Niemiecki Podstawy cz.2", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 31, TypeId = 3, AuthorId = 1, Price = 50, Title = "Niemiecki Gramatyka cz.1", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 32, TypeId = 3, AuthorId = 1, Price = 55, Title = "Niemiecki Gramatyka cz.2", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 33, TypeId = 3, AuthorId = 1, Price = 55, Title = "Niemiecki Gramatyka cz.3", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 34, TypeId = 3, AuthorId = 1, Price = 55, Title = "Niemiecki Nie gryzie! cz.1", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 35, TypeId = 3, AuthorId = 1, Price = 52, Title = "Niemiecki Nie gryzie! cz.2", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 36, TypeId = 3, AuthorId = 1, Price = 55, Title = "Niemiecki Nie gryzie! cz.3", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 37, TypeId = 3, AuthorId = 1, Price = 45, Title = "Niemiecki Rozmowki", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 38, TypeId = 3, AuthorId = 1, Price = 44, Title = "Niemiecki od podstaw", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 39, TypeId = 3, AuthorId = 1, Price = 22, Title = "Niemiecki dla studenta cz.1", ProductArtUrl = "/content/images/book.jpg" });
            context.Products.Add(new Product { ProductId = 40, TypeId = 3, AuthorId = 1, Price = 55, Title = "Niemiecki dla studenta cz.1", ProductArtUrl = "/content/images/book.jpg" });

            base.Seed(context);
        }
    }
}