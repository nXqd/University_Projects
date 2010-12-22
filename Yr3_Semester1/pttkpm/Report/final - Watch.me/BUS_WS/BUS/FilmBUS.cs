using System.Collections.Generic;
using BUS.DAL_WS;

namespace BUS
{
    public class FilmBUS
    {
        private Service1SoapClient _ws = new Service1SoapClient();
        public void InsertFilm(FilmDTO dto)
        {
            _ws.InsertFilm(dto);
        }
        public void RateFilm(string name, int rate)
        {
            _ws.RateFilm(name, rate);
        }
        public FilmDTO[] SearchFilmByName(string name)
        {
            return _ws.SearchFilmByName(name);
        }
        public void UpdateFilm(string id,FilmDTO dto)
        {
            _ws.UpdateFilm(id,dto);
        }
    }
}
