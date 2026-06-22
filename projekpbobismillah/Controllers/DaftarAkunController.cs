using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekpbobismillah.models;

namespace projekpbobismillah.Controllers
{   
    public class DaftarAkunController
    {
        public Member ProsesDaftar(string namaLengkap, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(namaLengkap))
            {
                throw new Exception("Nama lengkap wajib diisi.");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email wajib diisi.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password wajib diisi.");
            }

            string[] parts = namaLengkap.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string namaDepan = parts[0];
            string namaBelakang = parts.Length > 1
                ? string.Join(" ", parts, 1, parts.Length - 1)
                : "-";

            int memberId = Member.RegistrasiMemberBaru(namaDepan, namaBelakang, email, password);

            if (memberId > 0)
            {
                return new Member(memberId, email, password, namaLengkap);
            }

            return null;
        }
    }
}
