﻿using System;

namespace CSD.Util
{
    public static class NumberUtil
    {
        [Obsolete("This is removed since version 2.0.0. Use IsPrime", true)]
        public static bool IsPrimeNumber(this long val)
        {
            if (val <= 1)
                return false;

            long halfVal = val / 2;

            for (long i = 2; i <= halfVal; ++i)
                if (val % i == 0)
                    return false;

            return true;
        }

        public static bool IsPrime(this long val)
        {
            if (val <= 1)
                return false;

            if (val % 2 == 0)
                return val == 2;

            if (val % 3 == 0)
                return val == 3;

            if (val % 5 == 0)
                return val == 5;

            if (val % 7 == 0)
                return val == 7;

            long sqrtVal = (long)Math.Sqrt(val);

            for (long i = 11; i <= sqrtVal; i += 2)
                if (val % i == 0)
                    return false;

            return true;
        }
    }
}
