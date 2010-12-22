using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace DAO
{
    public abstract class DatabaseProvider
    {
        // Create, open and return sqlConnecion if ok, unless return null
        private const string DatabaseName = "CinemaDB.db3";
        private const string DataCreator =
            @"CREATE TABLE Member_Type (type_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,type_name varchar NOT NULL);" +
            @"CREATE TABLE Members (member_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,member_name varchar NOT NULL,member_phone varchar,member_email varchar NOT NULL,other_member_details text, member_type_id integer, member_username varchar, member_password varchar, member_status boolean NOT NULL DEFAULT false,FOREIGN KEY(member_type_id) REFERENCES Member_Type(type_id));";
        public static SQLiteConnection CreateConnection()
        {
            // check and create database
            // Tao db neu chua ton tai
            var dataPath = AppDomain.CurrentDomain.BaseDirectory ;
            var connString = @"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + DatabaseName; 
            SQLiteConnection cnn;

            if (!File.Exists(dataPath + DatabaseName))
            {
                // Create database
                SQLiteConnection.CreateFile(dataPath + DatabaseName);
                cnn = new SQLiteConnection(connString);
                cnn.Open();
                var cmd = cnn.CreateCommand();
                cmd.CommandText = DataCreator;
                    
                cmd.ExecuteNonQuery();

                cnn.Close();
            }
            else
            {
                cnn = new SQLiteConnection(connString);
            }

            return cnn;
        }

        // SQliteExecuteScalar
        public static object SqliteExecuteScalar(string q, SQLiteParameter[] pColl)
        {
            // If there's no parameter, insert NULL
            Object obj;
            SQLiteConnection cnn = CreateConnection();
            cnn.Open();
            using (DbTransaction dbTrans = cnn.BeginTransaction())
            {
                using (DbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = q;
                    if (pColl != null)
                        cmd.Parameters.AddRange(pColl);
                    obj = cmd.ExecuteScalar();

                    cmd.Dispose();
                }
                dbTrans.Commit();
                dbTrans.Dispose();
            }
            cnn.Close();
            cnn.Dispose();
            return obj;
        }

        // SQliteExecuteNonQuery
        public static object SqliteExecuteNonQuery(string q, SQLiteParameter[] pColl)
        {
            // If there's no parameter, insert NULL
            Object obj;
            var cnn = CreateConnection();
            cnn.Open();
            using (DbTransaction dbTrans = cnn.BeginTransaction())
            {
                using (DbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = q;
                    cmd.Parameters.AddRange(pColl);
                    obj = cmd.ExecuteNonQuery();

                    cmd.Dispose();
                }
                dbTrans.Commit();
                dbTrans.Dispose();
            }
            cnn.Close();
            cnn.Dispose();
            return obj;
        }

        // SQliteDataReader
        public static List<List<Object>> SqliteDataReader(string q, SQLiteParameter[] sqLiteParameters, int rows)
        {
            // If there's no parameter, insert NULL
            SQLiteDataReader dataReader;
            var objects = new List<List<Object>>();
            var cnn = CreateConnection();
            cnn.Open();
            using (DbTransaction dbTrans = cnn.BeginTransaction())
            {
                using (DbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = q;
                    if (sqLiteParameters != null)
                        cmd.Parameters.AddRange(sqLiteParameters);
                    dataReader = (SQLiteDataReader) cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        objects.Add(new List<object>());
                        for (int i = 0; i < rows; i++)
                        {
                            objects[objects.Count - 1].Add(dataReader[i]);
                        }
                    }
                    dataReader.Close();
                }
                dbTrans.Commit();
            }
            cnn.Close();
            return objects;
        }
    }
}