using FSSS.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSSS.DAL.Interface
{
    public interface IUserDao
    {
        int QuerySqlShow(string query, string log, string pass);
        void Registrate(string query, User user);
        void ChangeName(string query, string OldName, string name, int id);
        void ChangePassword(string query, string OldPas, string pas, int id);
        int GetNameForCreate(int id, string name);
        int GetPasswordForCreate(int id, string pas);
        int GetPasswordForRegistrate(string pas);
        int GetLoginForSend(string log);
    }
}
