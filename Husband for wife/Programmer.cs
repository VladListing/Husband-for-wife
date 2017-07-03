using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husband_for_wife
{
    class Programmer: IHusband
    {
        private int _money = 0;

        public int GetMoney()
        {
            return _money+100;
        }

    }
}
