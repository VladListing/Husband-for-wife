using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husband_for_wife
{
    public interface IHusband
    {
        //метод заработать деньги
        void EarnMoney();

        //метод отдать заработанные деньги
        int GetMoney();
    }
}
