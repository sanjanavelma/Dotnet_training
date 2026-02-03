using System;
public class IncreaseBy
    {
        public static void IB()
        {
            int x = 10;
            void incbyten(ref int a)
            {
                a = a + 10;
            }
            incbyten(ref x);
            Console.WriteLine(x);
        }
    }
