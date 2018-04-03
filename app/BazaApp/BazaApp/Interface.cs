using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaApp
{
    public interface Interface
    {
        DataGridView DataList { get; }
        bool DeleteItem(int index);
        string IdRowName { get; }
        string NameRowName { get; }
        bool AddItem(string name);
        void SortItemsOverName();
        void Load(string orderBy = null);
        string TableName { get; }
    }
}
