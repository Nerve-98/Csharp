using System;

class MyList<T>
{
    private T[] array;

    public MyList()
    {
        array = new T[3];

    }

    public T this[int index]
    {
        get { return array[index]; }
        set
        {
            if (index >= array.Length)
            {
                Array.Resize<T>(ref array, index + 1);
                Console.WriteLine($"Array Resized : {array.Length}");
            }
            array[index] = value;
        }

    }

    public int Length
    {
        get { return array.Length; }
    }

}

class MainApp
{
    static void Main(string[] args)
    {
        MyList<string> str_list = new MyList<string>();

        str_list[0] = "abc";

        if (str_list[1] == null)
            Console.WriteLine("str_list[1] is null");

        for (int i = 0; i < str_list.Length; i++)
            Console.WriteLine(str_list[i]);



    }

}



