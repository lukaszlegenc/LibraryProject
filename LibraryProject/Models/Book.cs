using System;

namespace LibraryProject.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImgPath { get; set; }

        /*public Book(string author, string title, string description, double price)
        {
            Author = author;
            Title = title;
            Description = description;
            Price = price;
        }

        public Book(string author, string title, string description, double price, string imgPath)
        {
            Author = author;
            Title = title;
            Description = description;
            Price = price;
            ImgPath = imgPath;
        }*/
    }
}
