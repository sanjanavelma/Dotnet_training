using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 public class MoveZero
    {
        public static void MoveZeros(int[] arr)
        {
            int writeIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[writeIndex] = arr[i];
                    writeIndex++;
                }
            }
            while (writeIndex < arr.Length)
            {
                arr[writeIndex] = 0;
                writeIndex++;
            }
        }

    }
