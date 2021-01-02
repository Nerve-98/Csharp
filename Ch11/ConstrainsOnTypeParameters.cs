using System;

class StructArray<T> where T : struct
{
    public T[] Array { get; set }
    public StructArray(int size)
    {
        Array = new T[size];

    }
}


class RefArray<T> where T : class
{
    public T[] Array { get; set; }
    public RefArray(int size)
    {
        Array = new T[size];
    }

}
