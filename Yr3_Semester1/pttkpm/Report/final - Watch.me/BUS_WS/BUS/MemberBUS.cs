using System.Collections.Generic;
using BUS.DAL_WS;

namespace BUS
{
    public class MemberBUS
    {
        private Service1SoapClient _ws = new Service1SoapClient();
        public List<string> GetMembers()
        {
            return _ws.GetMembers();
        }
        public MemberDTO Login(string usr,string pass)
        {
            return _ws.Login(usr, pass);
        }
        public void Logout(string name)
        {
            _ws.Logout(name);
        }
        public void Register(string name, string phone, string email, string xmlDetails, string typeID, string usr, string pass)
        {
            _ws.Register(name, phone, email, xmlDetails, typeID, usr, pass);
        }
        public void DeleteMember(string usrname)
        {
            _ws.DeleteMember(usrname);
        }
    }
}
