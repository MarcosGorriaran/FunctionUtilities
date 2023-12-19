using System;

namespace Utilities
{
    public class ArrayConverters
    {
        public static int[] StrToIntConv(string[] values)
        {
            int[] result = new int[values.Length];
            for(int i = 0; i<values.Length; i++)
            {
                result[i] = Convert.ToInt32(values[i]);
            }
            return result;
        }
        public static long[] StrToLongConv(string[] values)
        {
            long[] result = new long[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                result[i] = Convert.ToInt64(values[i]);
            }
            return result;
        }
    }
}
