 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace projekpbobismillah
{
    public static class DatabaseHelper
    {
        private static string connString = "Host=localhost; Port=5432; Username=postgres; Password=safirah74; Database=pbofixamin";
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
        public static void ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Database (Execute): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
        public static DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Database (Query): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt; 
        }
    }
}