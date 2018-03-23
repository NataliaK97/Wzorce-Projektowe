using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fabryka
  
{
    public static class factory
    {
        public static Interface1 getObject(string className)
        {
            if (className.Equals("Users"))
                return new users();

            if (className.Equals("Products"))
                return new products();

            throw new Exception("Nie można utworzyć nowego obiektu!");
        }
    }
}
    }
}
