using FSSS.BLL.Interface;
using FSSS.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSSS.BLL
{
    public class UserLogic:IUserLogic
    {
        private IUserDao userDao;

        public UserLogic(IUserDao usDao)
        {
            userDao = usDao;
        }

        public int QuerySqlShow(string query, string log, string pass)
        {
            return userDao.QuerySqlShow(query, log, pass);
        }

        public void Registrate(string query, string name, string log, string pass)
        {
            userDao.Registrate(query, name, log, pass);
        }
    }
}
