using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSSS.BLL.Interface
{
    public interface IFileLogic
    {
        void AddFile(string query, string name, DateTime date, int size, int id);
        void ShowFile(string query, DataGridView DGV, int k);
        void DeleteFile(string query, string title, DateTime date, int id);
        void UpdateFile(string query, string oldName, string name, int id);
        void FindFile(string query, DataGridView DGV, string name, int k);
        void SendFile(string query, string name, string log, int id);
    }
}
