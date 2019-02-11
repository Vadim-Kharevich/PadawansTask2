using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int sum = 0;
            int sumadd = 0;
            for (int i = 0; i < count; i++)
            {
                sum += number + sumadd;
                sumadd += add;
            }
            return sum;
        }
    }
}
