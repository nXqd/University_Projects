using System;
using System.Data.OleDb;

namespace QLHS_WCF
{
    public class DataProvider {
        private const string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\dev\qlsv.accdb;Persist Security Info=False;";
        private static OleDbConnection _conn;
        public static OleDbConnection Connection { get { return _conn ?? (_conn = new OleDbConnection(ConnStr)); } }
    }
}