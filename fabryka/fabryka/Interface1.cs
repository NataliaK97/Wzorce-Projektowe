using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabryka
{
    public interface Interface1
    {
        String listItems();
        String addItem(String user);
        String deleteItem(int number);
        String sortItems();
    }
}
