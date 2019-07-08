using FSSS.BLL.Interface;
using FSSS.DAL.Interface;
using FSSS.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSSS.BLL
{
    public class UserLogic:IUserLogic
    {
        private IUserDao _userDao;

        public UserLogic(IUserDao usDao)
        {
            _userDao = usDao;
        }

        public int QuerySqlShow(string query, string log, string pass)
        {
            return _userDao.QuerySqlShow(query, log, pass);
        }

        public void Registrate(string query, User user)
        {
            _userDao.Registrate(query, user);
        }

        public void ChangeName(string query, string OldName, string name, int id)
        {
            _userDao.ChangeName(query, OldName, name, id);
        }

        public void ChangePassword(string query, string OldPas, string pas, int id)
        {
            _userDao.ChangePassword(query, OldPas, pas, id);
        }

        public int GetNameForCreate(int id, string name)
        {
            return _userDao.GetNameForCreate( id,  name);
        }

        public int GetPasswordForCreate(int id, string pas)
        {
            return _userDao.GetPasswordForCreate(id, pas);
        }

        public int GetPasswordForRegistrate(string pas)
        {
            return _userDao.GetPasswordForRegistrate(pas);
        }

        public int GetLoginForSend(string log)
        {
            return _userDao.GetLoginForSend(log);
        }
    }
}
