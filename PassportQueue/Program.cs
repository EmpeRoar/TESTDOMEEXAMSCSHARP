using System;
using System.Collections;

public class Entry
{
    private static Queue _queue = new Queue();
    public void Enter(string passportNumber)
    {
        _queue.Enqueue(passportNumber);
    }

    public string Leave()
    {
        return _queue.Count != 0 ? _queue.Dequeue().ToString() : null;
    }

    public static void Main(string[] args)
    {
        Entry entry = new Entry();
        entry.Enter("AB54321");
        entry.Enter("UK32032");
        Console.WriteLine(entry.Leave());
        Console.WriteLine(entry.Leave());
        Console.ReadLine();
    }
}