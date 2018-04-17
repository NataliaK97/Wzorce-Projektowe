using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class PersonFacade
    {
        Person person;
        string name;

        public PersonFacade(Person user)
        {
            this.person = user;
        }

        public string GetName()
        {
            name = person.GetFirstName() + " " + person.GetLastName();
            return name;
        }
    }
}
