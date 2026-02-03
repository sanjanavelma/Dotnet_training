using System;
using System.Collections.Generic;
class Repository<T> where T : class
        {
            public T Data; //only reference types are allowed - class, string, obj, array
        }
class Customer
{
    public String Name;
}

