using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.Controllers
{
    public class DashboardController
    {
        private List<Book> _semuaBuku = new List<Book>();

        public List<Book> MuatBuku()
        {
            _semuaBuku = Book.AmbilSemuaBuku();
            return _semuaBuku;
        }

        public List<Book> CariBuku(string kataKunci)
        {
            string keyword = kataKunci.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword) || keyword == "cari buku...")
            {
                return _semuaBuku;
            }

            return _semuaBuku.Where(b =>
                b.Judul.ToLower().Contains(keyword) ||
                b.Author.ToLower().Contains(keyword)).ToList();
        }
    }
}
