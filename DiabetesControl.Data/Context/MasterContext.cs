using DiabetesControl.Data.Models;
using DiabetesControl.Data.Models.SettingManager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiabetesControl.Data.Context
{
    public class MasterContext : DbContext
    {
        public MasterContext()
        {

        }
        public MasterContext(DbContextOptions<MasterContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(new MySqlServerVersion(new Version(8, 0, 22)), SettingsManager.DatabaseSettings.GetConnectionString());
            }
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Food>().HasKey(x => new { x.Id });
            //modelBuilder.Entity<NutritionalMeasure>().HasKey(x => new { x.Id });
            //modelBuilder.Entity<NutritiveGroup>().HasKey(x => new { x.Id });
            //modelBuilder.Entity<NutritiveValue>().HasKey(x => new { x.Id });

            // modelBuilder.Entity<Food>().HasOne()
            base.OnModelCreating(modelBuilder);
        }

        DbSet<Food> Foods { get; set; }
        DbSet<NutritiveGroup> NutritiveGroups { get; set; }
        DbSet<NutritionalMeasure> NutritionalMeasures { get; set; }
        DbSet<NutritiveValue> NutritiveValue { get; set; }
    }
}