using DiabetesControl.Data.Models;
using DiabetesControl.Data.Models.SettingManager;
using DiabetesControl.Utils.Logger;
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
                optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("MYSQL_URI"),
                    ServerVersion.AutoDetect(Environment.GetEnvironmentVariable("MYSQL_URI")));
                ElasticLogger.Instance.Info("Connetion");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        DbSet<Food> Foods { get; set; }
        DbSet<NutritionalMeasure> NutritionalMeasures { get; set; }
        DbSet<NutritiveValue> NutritiveValue { get; set; }
    }
}