using System;

namespace Generic_CS
{
    public class MyGenericClass<T>
    {
        public void display()
        {
                Console.Write(typeof(T));
        }
    }
}
