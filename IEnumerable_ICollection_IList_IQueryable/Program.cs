using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Queue<string> myQueue = new();
        myQueue.Enqueue("Hello");
        myQueue.Enqueue("Hello2");
        myQueue.Enqueue("Hello3");
        myQueue.Enqueue("Hello4");
        myQueue.Enqueue("Hello5");
        foreach (var item in myQueue)
        {
            Console.WriteLine(item.ToString());
        }
        Console.ReadLine();
        Console.WriteLine("Beginning Item is: " + myQueue.Peek());



        myQueue.Clear();
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }

        Stack<string> stack = new Stack<string>();
        //ArrayList
        stack.Push("Hello");
        stack.Push("Hello2");
        stack.Push("Hello3");
        stack.Push("Hello4");
        stack.Push("Hello5");
        stack.Push("Hello6");


        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        List<string> asd = new();
        asd.Add("Hello");
        asd.Add("Hello");
        asd.Add("Hello");
        asd.Add("Hello");
        asd.Add("Hello");
        asd.Add("Hello");
        var x = asd.AsQueryable();
        foreach (var item in x)
        {
            Console.WriteLine(item);
        }



        var numbers = Enumerable.Range(1, 10);
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }


        Queue queue = new Queue();
        
}
}