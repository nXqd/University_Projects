using System.Collections.Generic;
using System.Web.Services;
using BUS;
using BUS.DAL_WS;

namespace BUS_WS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        #region Member
        [WebMethod]
        public List<string> GetMembers()
        {
            var bus = new MemberBUS();
            return bus.GetMembers();
        }
        [WebMethod]
        public MemberDTO Login(string usr, string pass)
        {
            var bus = new MemberBUS();
            return bus.Login(usr, pass);
        }
        [WebMethod]
        public void Logout(string name)
        {
            var bus = new MemberBUS();
            bus.Logout(name);
        }
        [WebMethod]
        public void Register(string name, string phone, string email, string xmlDetails, string typeID, string usr, string pass)
        {
            var bus = new MemberBUS();
            bus.Register(name, phone, email, xmlDetails, typeID, usr, pass);
        }
        [WebMethod]
        public void DeleteMember(string usr)
        {
            var bus = new MemberBUS();
            bus.DeleteMember(usr);
        }
        #endregion
        #region Film
        [WebMethod]
        public void InsertFilm(FilmDTO dto)
        {
            var bus = new FilmBUS();
            bus.InsertFilm(dto);
        }
        [WebMethod]
        public void RateFilm(string name, int rate)
        {
            var bus = new FilmBUS();
            bus.RateFilm(name, rate);
        }
        public FilmDTO[] SearchFilmByName(string name)
        {
            var bus = new FilmBUS();
            return bus.SearchFilmByName(name);
        }
        public void UpdateFilm(string id, FilmDTO dto)
        {
            var bus = new FilmBUS();
            bus.UpdateFilm(id, dto);
        }
        #endregion
    }
}