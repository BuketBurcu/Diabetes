using System;
using System.Collections.Generic;
using System.Text;

namespace DiabetesControl.Data.Models.SettingManager
{
    /// <summary>
    /// Uygulama üzerindeki tüm ayarların static olarak her yerden erişilebilir şekilde tutulduğu yönetici sınıf.
    /// </summary>
    public static class SettingsManager
    {
        public static DatabaseSettingsModel DatabaseSettings { get; } = new DatabaseSettingsModel();
    }
}
