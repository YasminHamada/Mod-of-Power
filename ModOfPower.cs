using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************

    public static class ModOfPow
    {

        public static long ModOfPower(long B, long P, long M)
        {
            long result_modOfPower = 1;
            long mod_power = 1;

            // Base Case 
            if (B == 0)
                return 0;
            if (P == 0)
                return 1;

           if (P % 2 == 0) // P is even 
            {
                mod_power = ModOfPower(B, P / 2, M); //conquer 
                result_modOfPower = (mod_power * mod_power) % M;
            }
            else  // P is odd
            {
                mod_power = ModOfPower(B, (P-1) / 2, M); //conquer
                result_modOfPower = ((B % M) * mod_power * mod_power ) % M;

            }
           
                return result_modOfPower;

        }
    }
}
