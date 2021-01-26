using System;
using System.Threading;

class SideTask
{
    int count;

    public SideTask(int count)
    {
        this.count = count;
    }

    public void KeepAlive()
    {
        try
        {

            while(count > 0)
            {
                Console.WriteLine($"{count--} left");
                Thread.Sleep(100);
               

            }
            Console.WriteLine("Count : 0");

        }
        catch(ThreadAbortException e)
        {
            Console.WriteLine(e);
            Thread.ResetAbort();
        }
        finally
        {
            Console.WriteLine("Clear resource...");
        }



    }
}


class MainApp
{
    static void Main(string[] args)
    {
        SideTask task = new SideTask(1000);
        Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
        t1.IsBackground = false;


        t1.Start();
        Thread.Sleep(10000);
        
        
        Console.WriteLine("Aborting thread...");
        t1.Abort();

        Console.WriteLine("Waiting until thread stops...");
        t1.Join();

        Console.WriteLine("Finished");


    }
}