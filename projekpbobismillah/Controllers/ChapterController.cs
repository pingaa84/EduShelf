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
            int number = int.Parse(numberStr);
            Chapter.TambahChapter(bukuId, number, title, isi);
        }

        public void PerbaruiChapter(int chapterId, string numberStr, string title, string isi)
        {
            int number = int.Parse(numberStr);
            Chapter.UpdateChapter(chapterId, number, title, isi);
        }

        public void ProsesHapusChapter(int chapterId)
        {
            Chapter.HapusChapter(chapterId);
        }
    }
}
