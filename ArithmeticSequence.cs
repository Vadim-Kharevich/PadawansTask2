﻿using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException();
            }
            int sum = 0;
            int sumadd = 0;
            for(int i = 0; i < count; i++)
            {
                sum += number + sumadd;
                sumadd += add;
                if(sum>=int.MaxValue|| sum <= int.MinValue)
                {
                    throw new OverflowException();
                }
            }
            return sum;
        }
    }
}
