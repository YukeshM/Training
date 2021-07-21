using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_1
{
    public interface IDematBenefits : IBenefits
    {
        void AvailFreeCreditScoreCheck();
        void GetDailyStockUpdates();
    }
}
