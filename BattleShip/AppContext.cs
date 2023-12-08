using System.Data.Entity;
using System.Data.SQLite;

namespace BattleShip {
    class AppContext : DbContext {        
        public AppContext() : base(new SQLiteConnection() {
            ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "G:\\Курсач\\BattleShip\\BattleShip\\DataBase.db", ForeignKeys = true }.ConnectionString
        }, true) {
            DbConfiguration.SetConfiguration(new SQLiteConfiguration());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Statistic> Statistics { get; set; }

    }
}