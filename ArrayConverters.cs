using System;

namespace Utilities
{
    public class ArrayConverters
    {
        public static int[] StrToNumConv(string[] values)
        {
            int[] result = new int[values.Length];
            for(int i = 0; i<values.Length; i++)
            {
                result[i] = Convert.ToInt32(values[i]);
            }
            return result;
        }
    }
}
