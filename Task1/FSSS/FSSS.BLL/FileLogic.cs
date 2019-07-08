using FSSS.BLL.Interface;
using FSSS.DAL.Interface;
using FSSS.Entitie;
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
        private IFileDao _fileDao;

        public FileLogic(IFileDao fDao)
        {
            _fileDao = fDao;
        }
        public void AddFile(string query, File file, int id)
        {
            _fileDao.AddFile(query,file, id);
        }

        public void ShowFile(string query, DataGridView DGV, int k)
        {
            _fileDao.ShowFile(query, DGV, k);
        }

        public void DeleteFile(string query, string title, DateTime date, int id)
        {
            _fileDao.DeleteFile(query, title, date, id);
        }

        public void UpdateFile(string query, string OldName, string name, int id)
        {
            _fileDao.UpdateFile(query,  OldName, name, id);
        }

        public void FindFile(string query, DataGridView DGV, string name, int k)
        {
            _fileDao.FindFile(query, DGV, name, k);
        }

        public void SendFile(string query, string name, string log, int id)
        {
            _fileDao.SendFile(query, name, log, id);
        }

        public int GetTitleForDelete(int id, string title)
        {
           return _fileDao.GetTitleForDelete(id, title);
        }

    }
}
