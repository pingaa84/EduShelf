using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.Controllers
{
    
        public class TransaksiController
        {
            public DataTable DapatkanRiwayatTransaksi(int memberId)
            {
                try
                {
                    return RiwayatTransaksi.AmbilTransaksiOlehMember(memberId);
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal memuat data transaksi dari model: " + ex.Message);
                }
            }
        }
    
}
