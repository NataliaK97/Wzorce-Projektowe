﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class OcenaZDziennka : OcenaFactory
    {
        public override Interface Dziennik()
        {
            return new Ocena();
        }
    }
}
