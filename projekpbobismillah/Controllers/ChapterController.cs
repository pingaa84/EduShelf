using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekpbobismillah.models;

namespace projekpbobismillah.Controllers
{
    public class ChapterController
    {
        public DataTable DapatkanDaftarChapter(int bukuId)
        {
            return Chapter.AmbilChapterByBuku(bukuId);
        }

        public void SimpanChapterBaru(int bukuId, string numberStr, string title, string isi)
        {
            int number = ValidasiNomorChapter(numberStr);

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception("Judul bab wajib diisi.");
            }

            Chapter.TambahChapter(bukuId, number, title, isi);
        }

        public void PerbaruiChapter(int chapterId, string numberStr, string title, string isi)
        {
            int number = ValidasiNomorChapter(numberStr);

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception("Judul bab wajib diisi.");
            }

            Chapter.UpdateChapter(chapterId, number, title, isi);
        }

        public void ProsesHapusChapter(int chapterId)
        {
            if (chapterId <= 0)
            {
                throw new Exception("Chapter tidak valid.");
            }

            Chapter.HapusChapter(chapterId);
        }

        private int ValidasiNomorChapter(string numberStr)
        {
            if (string.IsNullOrWhiteSpace(numberStr))
            {
                throw new Exception("Nomor bab wajib diisi.");
            }

            bool berhasil = int.TryParse(numberStr, out int number);

            if (!berhasil)
            {
                throw new Exception("Nomor bab harus berupa angka.");
            }

            if (number <= 0)
            {
                throw new Exception("Nomor bab harus lebih dari 0.");
            }

            return number;
        }
    }
}
