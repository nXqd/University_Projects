using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using DTO;

namespace DAO
{
    public class MemberDAO : DatabaseProvider
    {
        public static List<string> GetMembers()
        {
            var tmp = new List<String>();
            var objs = SqliteDataReader(@"select member_username from Members", null,1);
            if (objs != null) {
                tmp.AddRange(objs.Select(obj => obj[0].ToString()));
                return tmp;
            }
            return null;
        }
        public static MemberDTO Login(string usr, string pass)
        {
            var sqlParas = new[]
                              {
                                  new SQLiteParameter("@usr", usr),
                                  new SQLiteParameter("@pass", pass)
                              };
            var id = Convert.ToInt32(SqliteExecuteScalar(@"select member_id from Members where member_username = @usr and member_password = @pass", sqlParas));
            // check is usr and pass match
            if (id != 0)
            {
                var paras = new[]
                                {
                                    new SQLiteParameter("@id", id)
                                };
                // get DTO
                var listObj = SqliteDataReader(@"select member_name,member_phone,member_email,member_type_id,other_member_details from Members where member_id = @id", paras, 5);
                var dto = new MemberDTO{
                    Name = listObj[0][0].ToString(),
                    Phone = listObj[0][1].ToString(),
                    Email = listObj[0][2].ToString(),
                    XmlDetails = listObj[0][4].ToString()
                };
                // get type name
                var typeID = listObj[0][3].ToString();
                paras = new[]
                            {
                                new SQLiteParameter("@id", typeID)
                            };
                dto.Type = Convert.ToString(SqliteExecuteScalar(@"select type_name from Member_Type where type_id = @id", paras));
                return dto;
            }
            return null;
        }
        public static void Logout(string name)
        {
            var sqlParas = new[]
                               {
                                   new SQLiteParameter("@name", name),
                                   new SQLiteParameter("@status",false)
                               };
            SqliteExecuteNonQuery(@"update Members set member_status = @status where member_name = @name", sqlParas);
        }
        public static void Register(string name,string phone,string email,string xmlDetails,string typeID,string usr,string pass)
        {
            var sqlParas = new[]
                               {
                                   new SQLiteParameter("@name", name),
                                   new SQLiteParameter("@phone", phone),
                                   new SQLiteParameter("@email", email),
                                   new SQLiteParameter("@xmlDetails", xmlDetails),
                                   new SQLiteParameter("@typeID", typeID),
                                   new SQLiteParameter("@usr", usr),
                                   new SQLiteParameter("@pass", pass)
                               };
            SqliteExecuteNonQuery(
                @"insert into Members(member_name,member_phone,member_email,other_member_details,member_type_id,member_username,member_password)" 
                + @"values(@name,@phone,@email,@xmlDetails,@typeID,@usr,@pass)",sqlParas);
        }
        public static void DeleteMember(string username)
        {
            var para = new[]
                           {
                               new SQLiteParameter("@username", username),
                               new SQLiteParameter("@false", false)
                           };
            SqliteExecuteNonQuery(@"UPDATE Members SET member_enable = @false where member_username = @username", para);
        }
    }
}
