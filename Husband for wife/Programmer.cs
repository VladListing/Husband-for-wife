﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husband_for_wife
{
    public class Programmer: IHusband
    {
        private int _money=0;

        public void EarnMoney()
        {
            _money += 100;
        }

        public int GetMoney()
        {
            return _money;
        }

    }
}
