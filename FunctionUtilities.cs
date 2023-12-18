namespace Utilities
{
    public class FunctionUtilities
    {
        public static bool InRange(int compareValue, int firstValue, int secondValue, bool minInRange = true, bool maxInRange = true)
        {
            ReorderVarAsc(ref firstValue, ref secondValue);
            if (minInRange)
            {
                firstValue--;
            }
            if (maxInRange)
            {
                secondValue++;
            }

            return compareValue > firstValue && compareValue < secondValue;
        }
        public static void ReorderVarAsc(ref int firstValue, ref int secondValue)
        {
            if (firstValue > secondValue)
            {
                int aux = firstValue;
                firstValue = secondValue;
                secondValue = aux;
            }
        }
        public static void ReorderVarAsc(ref int[]values)
        {
            for(int i = 0; i < values.Length-1; i++) 
            {
                for(int j = i; j<values.Length ; j++)
                {
                    if (values[j] > values[i])
                    {
                        int aux = values[j];
                        values[j] = values[i];
                        values[i] = aux;
                    }
                }
            }
        }
        public static void ReorderVarDesc(ref int firstValue, ref int secondValue)
        {
            if (firstValue < secondValue)
            {
                int aux = firstValue;
                firstValue = secondValue;
                secondValue = aux;
            }
        }
        public static void ReorderVarDesc(ref int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = i; j < values.Length; j++)
                {
                    if (values[j] < values[i])
                    {
                        int aux = values[j];
                        values[j] = values[i];
                        values[i] = aux;
                    }
                }
            }
        }

        public static int AskUserValue(string askMsg = "Proporcioname un valor: ")
        {
            int result;
            Console.Write(askMsg);
            result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
    }
}