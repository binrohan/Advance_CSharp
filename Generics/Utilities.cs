using System;

namespace Generics
{
    // Where T: IComparable
    // Where T: Product
    // Where T: struct
    // Where T: class
    // Where T: new()


    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ?  a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}