using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husband_for_wife
{
    public class Wife : IWife
    {
        private int _sex = 0;
        private int _food = 0;
        IHusband _husband;

        protected  Wife( IHusband husband )
        {
            _husband = husband;
        }

        public int GetFood()
        {

            return _food + (_husband.GetMoney());
        }
        public int GetSex()
        {
            return _sex + (_husband.GetMoney());
        }

    }
}
