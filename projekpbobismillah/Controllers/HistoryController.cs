using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.Controllers
{
    public class HistoryController
    {
        public DataTable DapatkanRiwayat(int memberId)
        {
            try
            {
                return History.AmbilRiwayatOlehMember(memberId);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data dari model: " + ex.Message);
            }
        }
    }
}
