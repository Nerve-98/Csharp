using System;

class MyList
{
    private int[] array;

    public MyList()
    {
        array = new int[3];
    }

    public int this[int index]
    {
        get { return array[index]; }
    
        set
        {
            if ( index >= array.Length )
            {
                Array.Resize<int>(ref array, array.Length * 2);
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
        MyList list = new MyList();
        for (int i = 0; i < 5; i++)
            list[i] = i;

        for (int i = 0; i < list.Length; i++)
            Console.WriteLine(list[i]);



        /*
        Array Resized : 6
        0
        1
        2
        3
        4
        0
         */



    }


}


