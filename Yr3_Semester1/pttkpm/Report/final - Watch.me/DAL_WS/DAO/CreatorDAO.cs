using System;
using System.Data.SQLite;
using System.Xml.Linq;

namespace DAO
{
    public class CreatorDAO:DatabaseProvider
    {
        public static void InsertCreator(string name,string birth,string travia,string details,string typeNames) /* types: Name of type */
        {
            // gem xml ids of typeNames
            var typeIDs = new XDocument();
            var root = new XElement("types");

            foreach (var typeName in typeNames)
            {
                var para = new[]
                               {
                                   new SQLiteParameter("@name", name)
                               };
                var id = Convert.ToString(SqliteExecuteScalar(@"SELECT creator_type_id FROM Creator_Types WHERE creator_type_name = @name",para));
                root.Add(new XElement("id",id));
            }
            typeIDs.Add(root);
            

            // get type IDs
            var paras = new[] {
                                 new SQLiteParameter("@name", name),
                                 new SQLiteParameter("@date",birth), 
                                 new SQLiteParameter("@travia",travia), 
                                 new SQLiteParameter("@details",details),
                                 new SQLiteParameter("@typeIDs",typeIDs)
                              };
            SqliteExecuteNonQuery(@"insert into Creators(creator_name, creator_born_date, creator_travia, creator_other_details, creator_type_ids)"
                                  + @"values(@name, @date, @travia, @details, @typeIDs)",paras);
        }
        //public static void DeleteCreator(string name)
        public static void UpdateCreator(string ID,string name, string birth, string travia, string details, string typeNames)
        {
            // get ID of this creator

            // gem xml ids of typeNames
            var typeIDs = new XDocument();
            var root = new XElement("types");

            foreach (var typeName in typeNames)
            {
                var para = new[]
                               {
                                   new SQLiteParameter("@name", name)
                               };
                var id = Convert.ToString(SqliteExecuteScalar(@"SELECT creator_type_id FROM Creator_Types WHERE creator_type_name = @name", para));
                root.Add(new XElement("id", id));
            }
            typeIDs.Add(root);


            // get type IDs
            var paras = new[] {
                                new SQLiteParameter("@id",ID),
                                 new SQLiteParameter("@name", name),
                                 new SQLiteParameter("@date",birth), 
                                 new SQLiteParameter("@travia",travia), 
                                 new SQLiteParameter("@details",details),
                                 new SQLiteParameter("@typeIDs",typeIDs)
                              };
            SqliteExecuteNonQuery(
                @"UPDATE Creators SET creator_name = @name, creator_born_date = @date, creator_travia = @travia, creator_other_details = @details, creator_type_ids =  @typeIDs WHERE creator_id = @id",
                paras);
        }
    }
}

