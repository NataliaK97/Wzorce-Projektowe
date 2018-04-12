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
        ListView MyListView { get; }
        bool DeleteItem(string number);
        string IdRow { get; }
        string NameRow { get; }
        bool Sort { get; }
        bool AddItem(string name);
        void NameSort();
        void Load(string sort = null);
        string TableName { get; }
    }
}
