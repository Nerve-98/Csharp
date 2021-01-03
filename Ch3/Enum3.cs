using System;

class MainApp
{
    enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK }
    
    static void Main(string[] args)
    {
        // Console.WriteLine(DialogResult.YES.GetType());
        // MainApp+DialogResult

        // Console.WriteLine(DialogResult.YES);
        // YES

        Console.WriteLine((int)DialogResult.NO);
    }


}