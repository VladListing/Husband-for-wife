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

        public  Wife( IHusband husband )
        {
            _husband = husband;
        }

        public int GetFood()
        {
            _husband.EarnMoney();
            return _food += ((_husband.GetMoney())/5);
        }
        public int GetSex()
        {
            _husband.EarnMoney();
            return _sex += ((_husband.GetMoney())/10);
        }

    }
}
