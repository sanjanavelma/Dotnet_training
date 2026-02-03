using System;
using System.Collections;
using System.Collections.Generic;
public class Queses
    {
        public static void Qu()
    {
        Queue q = new Queue();
        q.Enqueue(10);
        q.Enqueue(20);
        Console.WriteLine(q.Dequeue());
    }
    }
