using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.Controllers
{
    public class SubscriptionController
    {
        public DataTable DapatkanDaftarSubscription()
        {
            return Subscription.AmbilSemuaSubscription();
        }

        public void SetujuiLangganan(int subId)
        {
            Subscription.UpdateStatusSubscription(subId, "active");
        }

        public void TolakLangganan(int subId)
        {
            Subscription.UpdateStatusSubscription(subId, "ditolak");
        }
    }
}

