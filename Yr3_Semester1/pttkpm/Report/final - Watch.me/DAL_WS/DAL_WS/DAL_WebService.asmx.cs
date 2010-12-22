using System.Collections.Generic;
using System.Web.Services;
using DAO;
using DTO;

namespace DAL_WS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
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
            return MemberDAO.GetMembers();
        }
             
        [WebMethod]
        public MemberDTO Login(string usr,string pass)
        {
            return MemberDAO.Login(usr, pass);
        }
        [WebMethod]
        public void Logout(string name)
        {
            MemberDAO.Logout(name);
        }
        [WebMethod]
        public void Register(string name,string phone,string email,string xmlDetails,string typeID,string usr,string pass)
        {
            MemberDAO.Register(name,phone,email,xmlDetails,typeID,usr,pass);
        }
        [WebMethod]
        public void DeleteMember(string usr)
        {
            MemberDAO.DeleteMember(usr);
        }
        #endregion
        #region Film
        [WebMethod]
        public void InsertFilm(FilmDTO dto)
        {
            FilmDAO.InsertFilm(dto);
        }
        [WebMethod]
        public void RateFilm(string name,int rate)
        {
            FilmDAO.RateFilm(name,rate);
        }
        [WebMethod]
        public List<FilmDTO> SearchFilmByName(string name)
        {
            return FilmDAO.SearchFilmByName(name);
        }
        [WebMethod]
        public void UpdateFilm(string id,FilmDTO dto)
        {
            FilmDAO.UpdateFilm(id,dto);
        }
        #endregion
        #region Creator
        [WebMethod]
        public void InsertCreator(string name,string birth,string travia,string details,string typeNames)
        {
            CreatorDAO.InsertCreator(name,birth,travia,details,typeNames);
        }
        [WebMethod]
        public void UpdateCreator(string ID,string name, string birth, string travia, string details, string typeNames)
        {
            CreatorDAO.UpdateCreator(ID,name,birth,travia,details,typeNames);
        }
        #endregion
    }
}