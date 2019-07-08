using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSSS.Entitie
{
    public class File
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime DateOfCreation { get; set; }

        public int Size { get; set; }

        public File() { }

        public File(string title, DateTime date, int size)
        {
            Title = title;
            DateOfCreation = date;
            Size = size;
        }

        public override string ToString()
        {
            return $"Id: {Id} Название: {Title} Дата создания:{DateOfCreation.ToShortDateString()} Размер: {Size}";
        }
    }
}
