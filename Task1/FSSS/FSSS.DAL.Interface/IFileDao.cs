using FSSS.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSSS.DAL.Interface
{
    public interface IFileDao
    {
        void AddFile(string query, File file, int id);
        void ShowFile(string query, DataGridView DGV, int k);
        void DeleteFile(string query, string title, DateTime date, int id);
        void UpdateFile(string query, string OldName, string name, int id);
        void FindFile(string query, DataGridView DGV, string name, int k);
        void SendFile(string query, string name, string log, int id);
        int GetTitleForDelete(int id, string title);

    }
}
