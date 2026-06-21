using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.Controllers
{
    public class DashboardAdminController
    {
        public string DapatkanTotalBuku()
        {
            return Admin.AmbilTotalBuku();
        }

        public DataTable DapatkanGrafikPremium()
        {
            return Admin.AmbilDataMemberPremium();
        }

        public DataTable DapatkanGrafikTotalMember()
        {
            return Admin.AmbilDataTotalMember();
        }

        public DataTable DapatkanGrafikRevenue()
        {
            return Admin.AmbilDataRevenue();
        }
    }
}
