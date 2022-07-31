using System;
namespace Generic
{

    // 5 Type of Constraint
    // Where T : IComparable
    // Where T : Product (class label any of the class label or subclass label)
    // Where T : struct
    // Where T : class
    // WHere T : new()
    public class Utililties<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        public void DoSomething(T value)
        {
            var obj = new T();
        }
        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
           //return a > b ? a : b;
        }
    }
}
