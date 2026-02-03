using System;
using System.Collections;
using System.Collections.Generic;
public class HashTable
    {
        public static void HT()
    {
        Hashtable ht = new Hashtable();
        ht.Add(1, "Sanjana");
        ht.Add(2, "User");
        foreach (DictionaryEntry var in ht)
        {
            Console.WriteLine(var.Key + " -> " + var.Value);
        }
    }
    }
