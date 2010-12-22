using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using DTO;

namespace DAO
{
    public class FilmDAO:DatabaseProvider
    {
        public static void InsertFilm(FilmDTO dto)
        {
            string xmlGenres;
            string xmlDetails;
            string xmlCreators;
            #region XMLGeneration
            // generate xml genres  
            {
                var xmlDoc = new XmlDocument();
                var root = xmlDoc.CreateElement("genres");
                // get id of genre
                foreach (var genreName in dto.Genres)
                {
                    var paras = new[]
                                    {
                                        new SQLiteParameter("@genreName", genreName)
                                    };
                    var genreID = Convert.ToString(SqliteExecuteScalar(@"select genre_id from Film_Genres where genre_name = @genreName", paras));
                    var idXml = xmlDoc.CreateElement("id");
                    idXml.Value = genreID;
                    root.AppendChild(idXml);
                }
                xmlDoc.AppendChild(root);
                xmlGenres = xmlDoc.OuterXml;
            }
            // generate xml details
            {
                var xmlDoc = new XmlDocument();
                var root = xmlDoc.CreateElement("details");
                
                var time = xmlDoc.CreateElement("time");
                time.Value = dto.Details[0];
                root.AppendChild(time);

                var lang = xmlDoc.CreateElement("lang");
                lang.Value = dto.Details[1];
                root.AppendChild(lang);

                var country = xmlDoc.CreateElement("country");
                country.Value = dto.Details[2];
                root.AppendChild(country);

                var release = xmlDoc.CreateElement("release");
                release.Value = dto.Details[3];
                root.AppendChild(release);

                xmlDoc.AppendChild(root);
                xmlDetails = xmlDoc.OuterXml;
            }
            // generate xml creators 
            {
                var xmlDoc = new XmlDocument();
                var root = xmlDoc.CreateElement("creators");
                foreach (var creatorName in dto.Creators)
                {
                    var paras = new[]
                                    {
                                        new SQLiteParameter("@creatorName", creatorName)
                                    };
                    var creatorID = Convert.ToString(SqliteExecuteScalar(@"select creator_id from Creators where creator_name = @creatorName", paras));
                    
                    var idXml = xmlDoc.CreateElement("id");
                    idXml.Value = creatorID;
                    root.AppendChild(idXml);
                }
                xmlDoc.AppendChild(root);
                xmlCreators = xmlDoc.OuterXml;
            }
            #endregion

            var sqlParas = new[]
                               {
                                   new SQLiteParameter("@name",dto.Name),
                                   new SQLiteParameter("@trailerURL",dto.TrailerURI),
                                   new SQLiteParameter("@desc",dto.Description),
                                   new SQLiteParameter("@genres",xmlGenres),
                                   new SQLiteParameter("@details",xmlDetails),
                                   new SQLiteParameter("@creators",xmlCreators),
                                   new SQLiteParameter("@posterURI",dto.PosterURI)
                               };
            SqliteExecuteNonQuery(
                @"insert into Films(film_name,film_trailer_uri,film_poster_img_uri,film_description,film_genre_ids,film_details,film_creator_ids)" 
                +  @"values(@name,@trailerURL,@posterURI,@desc,@genres,@details,@creators",sqlParas);
        }
        public static void UpdateFilm(string id,FilmDTO dto)
        {
            string xmlGenres;
            string xmlDetails;
            string xmlCreators;
            #region XMLGeneration
            // generate xml genres  
            {
                var xmlDoc = new XmlDocument();
                var root = xmlDoc.CreateElement("genres");
                // get id of genre
                foreach (var genreName in dto.Genres)
                {
                    var paras = new[]
                                    {
                                        new SQLiteParameter("@genreName", genreName)
                                    };
                    var genreID = Convert.ToString(SqliteExecuteScalar(@"select genre_id from Film_Genres where genre_name = @genreName", paras));
                    var idXml = xmlDoc.CreateElement("id");
                    idXml.Value = genreID;
                    root.AppendChild(idXml);
                }
                xmlDoc.AppendChild(root);
                xmlGenres = xmlDoc.OuterXml;
            }
            // generate xml details
            {
                var xmlDoc = new XmlDocument();
                var root = xmlDoc.CreateElement("details");

                var time = xmlDoc.CreateElement("time");
                time.Value = dto.Details[0];
                root.AppendChild(time);

                var lang = xmlDoc.CreateElement("lang");
                lang.Value = dto.Details[1];
                root.AppendChild(lang);

                var country = xmlDoc.CreateElement("country");
                country.Value = dto.Details[2];
                root.AppendChild(country);

                var release = xmlDoc.CreateElement("release");
                release.Value = dto.Details[3];
                root.AppendChild(release);

                xmlDoc.AppendChild(root);
                xmlDetails = xmlDoc.OuterXml;
            }
            // generate xml creators 
            {
                var xmlDoc = new XmlDocument();
                var root = xmlDoc.CreateElement("creators");
                foreach (var creatorName in dto.Creators)
                {
                    var paras = new[]
                                    {
                                        new SQLiteParameter("@creatorName", creatorName)
                                    };
                    var creatorID = Convert.ToString(SqliteExecuteScalar(@"select creator_id from Creators where creator_name = @creatorName", paras));

                    var idXml = xmlDoc.CreateElement("id");
                    idXml.Value = creatorID;
                    root.AppendChild(idXml);
                }
                xmlDoc.AppendChild(root);
                xmlCreators = xmlDoc.OuterXml;
            }
            #endregion

            var sqlParas = new[]
                               {
                                   new SQLiteParameter("@name",dto.Name),
                                   new SQLiteParameter("@trailerURL",dto.TrailerURI),
                                   new SQLiteParameter("@desc",dto.Description),
                                   new SQLiteParameter("@genres",xmlGenres),
                                   new SQLiteParameter("@details",xmlDetails),
                                   new SQLiteParameter("@creators",xmlCreators),
                                   new SQLiteParameter("@posterURI",dto.PosterURI)
                               };
            SqliteExecuteNonQuery( @"UPDATE Films SET" 
                                    + @" film_name = @name," 
                                    + @" film_trailer_uri = @trailerURI," 
                                    + @" film_poster_img_uri = @posterURI," 
                                    + @" film_description = @desc," 
                                    + @" film_genre_ids = @genres,"
                                    + @" film_details = @details," 
                                    + @" film_creator_ids = @creators" 
                                    + @" WHERE film_id = @id", sqlParas);
            SqliteExecuteNonQuery(
                @"insert into Films(film_name,film_trailer_uri,film_poster_img_uri,film_description,film_genre_ids,film_details,film_creator_ids)"
                + @"values(@name,@trailerURL,@posterURI,@desc,@genres,@details,@creators", sqlParas);
        }
        public static void RateFilm(string name,int rate)
        {
            int times;
            decimal rating;
            {
                var paras = new[]
                                {
                                    new SQLiteParameter("@name", name),
                                };
                times =
                    Convert.ToInt32(SqliteExecuteScalar(@"select film_rate_times from Films where film_name = @name",
                                                        paras));
                rating =
                    Convert.ToDecimal(SqliteExecuteScalar(@"select film_rating from Films where film_name = @name",
                                                          paras));
            }
            {
                times += 1;
                rating = (rating + rate)/times;

                var paras = new[]
                                {
                                    new SQLiteParameter("@name", name),
                                    new SQLiteParameter("@rating", rating),
                                    new SQLiteParameter("@times", times)
                                };
                SqliteExecuteNonQuery(
                    @"update Films set film_rate_times = @times, film_rating = @rating where film_name = @name", paras);
            }
        }
        public static List<FilmDTO> SearchFilmByName(string name)
        {
            var tmp = new List<FilmDTO>();
            var paras = new[]
                            {
                                new SQLiteParameter("@name", name),
                            };
            var objects = SqliteDataReader(@"select film_name,film_description,film_trailer_uri,film_rating,film_rate_times,film_poster_img_uri,film_genre_ids,film_creator_ids,film_details from Films where film_name = @name limit 5;", paras, 8);
            foreach (var obj in objects)
            {
                var dto = new FilmDTO();
                dto.Name = obj[0].ToString();
                dto.Description = obj[1].ToString();
                dto.TrailerURI = obj[2].ToString();
                dto.Rating = decimal.Parse(obj[3].ToString());
                dto.RateTimes = int.Parse(obj[4].ToString());
                dto.PosterURI = obj[5].ToString();
                #region Parse XML
                // genres *id
                {
                    var doc = XDocument.Parse(obj[6].ToString());
                    var ids = (from id in doc.Descendants("id")
                               select id.Value).ToList();
                    //query datase to get genre name of ids
                    foreach (var id in ids)
                    {
                        var para = new[]
                                        {
                                            new SQLiteParameter("@id", id)
                                        };
                        var genreName = Convert.ToString(SqliteExecuteScalar(@"select genre_name from genre_id = @id", para));
                        dto.Genres.Add(genreName);
                    }
                }
                // creators *id, only get name of creators
                {
                    var doc = XDocument.Parse(obj[7].ToString());
                    var ids = (from id in doc.Descendants("id")
                               select id.Value).ToList();
                    //query datase to get genre name of ids
                    foreach (var id in ids)
                    {
                        var para = new[]
                                        {
                                            new SQLiteParameter("@id", id)
                                        };
                        var creatorName = Convert.ToString(SqliteExecuteScalar(@"select creator_name from Creators where creator_id = @id", para));
                        dto.Creators.Add(creatorName);
                    }
                }
                // details : time,lang,country,release 
                {
                    var doc = XDocument.Parse(obj[8].ToString());
                    var time = (from node in doc.Descendants("time")
                                select node.Value).FirstOrDefault();
                    var lang = (from node in doc.Descendants("lang")
                                select node.Value).FirstOrDefault();
                    var country = (from node in doc.Descendants("country")
                                select node.Value).FirstOrDefault();
                    var release = (from node in doc.Descendants("release")
                                select node.Value).FirstOrDefault();
                    dto.Details.Add(time);
                    dto.Details.Add(lang);
                    dto.Details.Add(country);
                    dto.Details.Add(release);
                }

                #endregion


            }
            return null;
            //TODO: Search like [slow]
        }
    }
}
