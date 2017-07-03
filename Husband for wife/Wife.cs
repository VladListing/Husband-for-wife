using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husband_for_wife
{
    class Wife : IWife
    {
        private int _sex = 0;
        private int _food = 0;

        public int GetFood()
        {
            return _food + 1;
        }
        public int GetSex()
        {
            return _sex + 1;
        }

    }
}
