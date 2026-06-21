using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekpbobismillah.form;
using projekpbobismillah.models;

namespace projekpbobismillah.Controllers
{
        public class ManajemenBukuController
        {
            public List<Book> DapatkanSemuaBuku()
            {
                return Book.AmbilSemuaBuku();
            }

            public bool ProsesSimpanBuku(Book book)
            {
                if (string.IsNullOrWhiteSpace(book.Judul) || string.IsNullOrWhiteSpace(book.Author))
                {
                    return false;
                }
                Book.TambahBuku(book);
                return true;
            }

            public bool ProsesUpdateBuku(Book book)
            {
                if (string.IsNullOrWhiteSpace(book.Judul) || string.IsNullOrWhiteSpace(book.Author) || string.IsNullOrEmpty(book.IDBuku))
                {
                    return false;
                }
                Book.UbahBuku(book);
                return true;
            }

            public void ProsesHapusBuku(string id)
            {
                Book.HapusBuku(id);
            }
        }
}
