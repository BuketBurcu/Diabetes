using System;
using System.Collections.Generic;
using System.Text;

namespace DiabetesControl.Data.Models.SettingManager
{
    public class DatabaseSettingsModel
    {
        /// <summary>
        /// Connectionstring bilgisini veren method.
        /// </summary>
        /// <returns>Bağlantı adresi</returns>
        public string GetConnectionString()
        {
            string connectionString = $"" +
                $"server={Environment.GetEnvironmentVariable("MYSQL_IP")};" +
                $"database={Environment.GetEnvironmentVariable("MYSQL_DATABASE")};" +
                $"user={Environment.GetEnvironmentVariable("MYSQL_USER")};" +
                $"password={Environment.GetEnvironmentVariable("MYSQL_PASSWORD")};" +
                $"Polling={Environment.GetEnvironmentVariable("POOLING")};" +
                $"MinimumPoolSize={Environment.GetEnvironmentVariable("MIN_PS")};" +
                $"MaximumPoolSize={Environment.GetEnvironmentVariable("MAX_PS")};" +
                $"port={Environment.GetEnvironmentVariable("MYSQL_PORT")}";
            return connectionString;
        }
    }
}
