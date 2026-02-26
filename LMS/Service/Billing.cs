using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Service
{
    internal static class Billing
    {
        internal static double bill(double basePrice, double MaintainCharge)
        {
            if (basePrice <= 0)
            {
                return 0;
            }
            if (MaintainCharge < 0) { return 0; }

            return basePrice + MaintainCharge;
        }
    }
}
