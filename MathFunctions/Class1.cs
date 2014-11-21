namespace MathFunctions
{
    public  class Statistics
    {
        public static double Factorial(double value)
        {
            if (value < 1)
            {
                return 0;
            }
            else
            {
                double res = 1;
                for (int i = 2; i < value; i++)
                {
                    res = res * value;
                }
                return res;
            }
        }
    }

    public class ArrayOpera
    {
        public static float Max(float[] array)
        {
            float max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static float Min(float[] array)
        {
            float min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static float SumOfElements(float[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static float ArithmeticAverage(float[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sum = sum / array.Length;
            return sum;
        }

        public static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int SumOfElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static int ArithmeticAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sum = sum / array.Length;
            return sum;
        }
    }
}
