using FSSS.BLL;
using FSSS.BLL.Interface;
using FSSS.DAL;
using FSSS.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSSS.COMMON
{
    public class CommonAp
    {
        private static IUserDao userDao;

        public static IUserDao UserDao => userDao ?? (userDao = new UserDao());

        private static IUserLogic userLogic;

        public static IUserLogic UserLogic => userLogic ?? (userLogic = new UserLogic(UserDao));

        private static IFileDao fileDao;

        public static IFileDao FileDao => fileDao ?? (fileDao = new FileDao());

        private static IFileLogic fileLogic;

        public static IFileLogic FileLogic => fileLogic ?? (fileLogic = new FileLogic(FileDao));
    }
}
