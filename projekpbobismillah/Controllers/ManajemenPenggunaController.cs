using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using projekpbobismillah.form;
using projekpbobismillah.models;

namespace projekpbobismillah.Controllers
{
    public class ManajemenPenggunaController
    {
        public DataTable DapatkanDaftarMember()
        {
            try
            {
                return Member.AmbilSemuaDaftarMember();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat data member: " + ex.Message);
            }
        }
    }
}
