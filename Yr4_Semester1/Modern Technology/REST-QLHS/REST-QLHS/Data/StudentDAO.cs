using System.Collections.Generic;
using System.Data.SQLite;
using REST_QLHS.Model;

namespace REST_QLHS.Data {
    public class StudentDAO {
        private static SQLiteCommand _cmd;

        public List<StudentDTO> GetAll() {
            var dtos = new List<StudentDTO>();
            _cmd = DataProvider.Conn.CreateCommand();
            _cmd.CommandText = "SELECT * FROM Student WHERE status = 1";
            DataProvider.Conn.Open();
            SQLiteDataReader reader = null;
            try
            {
                reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    var dto = new StudentDTO
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Avg = reader.GetFloat(2),
                        Status = reader.GetBoolean(3),
                        Code = reader.GetString(4),
                        Birthday = reader.GetDateTime(5),
                        Image = reader.GetString(5),
                    };
                    dtos.Add(dto);
                }
            }
            catch {
                return null;
            }
            finally {
                if (reader != null) reader.Close();
            }
            DataProvider.Conn.Close();

            return dtos;
        }

        public StudentDTO Get(StudentDTO student) {
            _cmd = DataProvider.Conn.CreateCommand();
            _cmd.CommandText = "SELECT * FROM Student where id = @id";
            _cmd.Parameters.Add(new SQLiteParameter("@id", student.Id));
            DataProvider.Conn.Open();
            try
            {
                var reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    student.Id = reader.GetInt32(0);
                    student.Name = reader.GetString(1);
                    student.Avg = reader.GetFloat(2);
                    student.Status = reader.GetBoolean(3);
                    student.Code = reader.GetString(4);
                    student.Birthday = reader.GetDateTime(5);
                    student.Image = reader.GetString(5);
                }
            }
            catch {
                return null;
            }
            finally {
                DataProvider.Conn.Close();
            }

            return student;
        }

        public StudentDTO Delete(StudentDTO student) {
            _cmd = DataProvider.Conn.CreateCommand();
            _cmd.CommandText = "UPDATE Student SET status = 0 WHERE id = @id";
            _cmd.Parameters.Add(new SQLiteParameter("@id", student.Id));

            DataProvider.Conn.Open();
            try { _cmd.ExecuteNonQuery(); }
            catch { return null; }
            finally { DataProvider.Conn.Close(); }

            return student;
        }

        public StudentDTO Create(StudentDTO student) {
            _cmd = DataProvider.Conn.CreateCommand();
            _cmd.CommandText = "INSERT INTO Student(name,avg,status,code,birthday,image) VALUES(@name,@avg,@status,@code,@birthday,@image)";
            _cmd.Parameters.Add(new SQLiteParameter("@name", student.Name));
            _cmd.Parameters.Add(new SQLiteParameter("@avg", student.Avg));
            _cmd.Parameters.Add(new SQLiteParameter("@status", student.Status));
            _cmd.Parameters.Add(new SQLiteParameter("@code", student.Code));
            _cmd.Parameters.Add(new SQLiteParameter("@birthday", student.Birthday));
            _cmd.Parameters.Add(new SQLiteParameter("@image", student.Image));

            DataProvider.Conn.Open();
            try { _cmd.ExecuteNonQuery(); }
            catch { return null; }
            finally { DataProvider.Conn.Close(); } 

            return student;
        }


        public StudentDTO Update(StudentDTO student) {
            _cmd = DataProvider.Conn.CreateCommand();
            _cmd.CommandText =
                "UPDATE Student SET name=@name, [avg]=@avg,status=@status,code=@code,birthday=@birthday,image=@image WHERE id=@id";
            _cmd.Parameters.Add(new SQLiteParameter("@id", student.Id));
            _cmd.Parameters.Add(new SQLiteParameter("@name", student.Name));
            _cmd.Parameters.Add(new SQLiteParameter("@avg", student.Avg));
            _cmd.Parameters.Add(new SQLiteParameter("@status", student.Status));
            _cmd.Parameters.Add(new SQLiteParameter("@code", student.Code));
            _cmd.Parameters.Add(new SQLiteParameter("@birthday", student.Birthday));
            _cmd.Parameters.Add(new SQLiteParameter("@image", student.Image));

            DataProvider.Conn.Open();
            try { _cmd.ExecuteNonQuery(); }
            catch { return null; }
            finally { DataProvider.Conn.Close(); } 

            return student;
        }
    }
}