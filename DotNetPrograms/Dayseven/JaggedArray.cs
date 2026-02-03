using System;
public class JaggedArray
    {
        public static void jaggedd()
    {
        int[][] jagged = new int[2][];
        jagged[0] = new int[]{1, 2};
        jagged[1] = new int[]{3, 4, 5};
        for(int i = 0; i < jagged.Length; i ++)
        {
            for(int j = 0; j <jagged[i].Length; j ++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    }
