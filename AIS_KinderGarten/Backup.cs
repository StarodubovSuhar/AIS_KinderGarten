using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП
{
    class Backup
    {
        public void getBackup()
        {
            DateTime dt = DateTime.Now;
            string constring = "server=localhost;username=root;password=;database=project_db;";
            string file = "D:\\backup_" + dt.ToString("d") + ".sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }

    }
}
