using System;
using System.Configuration;
using System.Data.SQLite;

namespace REST_QLHS.Data {
    public static class DataProvider {
        public static SQLiteConnection Conn;

        static DataProvider() {
            var connString = ConfigurationManager.ConnectionStrings["HocSinhEntities"].
                ConnectionString.Replace("%App%", AppDomain.CurrentDomain.BaseDirectory);
                                                                                        
            Conn = new SQLiteConnection(connString);
        }
    }
}