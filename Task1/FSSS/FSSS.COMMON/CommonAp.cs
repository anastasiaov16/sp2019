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
        private static IUserDao _userDao;

        public static IUserDao UserDao => _userDao ?? (_userDao = new UserDao());

        private static IUserLogic _userLogic;

        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao));


        private static IFileDao _fileDao;

        public static IFileDao FileDao => _fileDao ?? (_fileDao = new FileDao());

        private static IFileLogic _fileLogic;

        public static IFileLogic FileLogic => _fileLogic ?? (_fileLogic = new FileLogic(FileDao));
    }
}
