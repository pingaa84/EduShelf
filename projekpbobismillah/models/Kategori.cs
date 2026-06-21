using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.models
{
    public class Kategori
    {
        public int IDCategory { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public Kategori(int id, string name, string description)
        {
            IDCategory = id;
            Name = name;
            Description = description;
        }
        public void AddBook(Book book)
        {
            if (!Books.Contains(book))
            {
                Books.Add(book);
                book.IDCategory = this.IDCategory;
                Console.WriteLine($"Buku '{book.Judul}' ditambahkan ke kategori '{Name}'");
            }
        }

        public void RemoveBook(Book book)
        {
            if (Books.Contains(book))
            {
                Books.Remove(book);
                Console.WriteLine($"Buku '{book.Judul}' dihapus dari kategori '{Name}'");
            }
        }
    }
}
