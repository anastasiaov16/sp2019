using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSSS.BLL.Interface
{
    public interface IUserLogic
    {
        int QuerySqlShow(string query, string log, string pass);
        void Registrate(string query, string name, string log, string pass);
    }
}
