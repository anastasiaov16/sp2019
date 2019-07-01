using FSSS.BLL.Interface;
using FSSS.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSSS.BLL
{
    public class FileLogic:IFileLogic
    {
        private IFileDao fileDao;

        public FileLogic(IFileDao fDao)
        {
            fileDao = fDao;
        }
        public void AddFile(string query, string name, DateTime date, int size, int id)
        {
            fileDao.AddFile(query, name, date, size, id);
        }

        public void ShowFile(string query, DataGridView DGV, int k)
        {
            fileDao.ShowFile(query, DGV, k);
        }

        public void DeleteFile(string query, string title, DateTime date, int id)
        {
            fileDao.DeleteFile(query, title, date, id);
        }

        public void UpdateFile(string query, string oldName, string name, int id)
        {
            fileDao.UpdateFile(query,  oldName, name, id);
        }

        public void FindFile(string query, DataGridView DGV, string name, int k)
        {
            fileDao.FindFile(query, DGV, name, k);
        }

        public void SendFile(string query, string name, string log, int id)
        {
            fileDao.SendFile(query, name, log, id);
        }
    }
}
