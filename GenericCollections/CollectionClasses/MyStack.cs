using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCollections.CollectionInterfaces;

namespace GenericCollections.CollectionClasses
{
    public class MyStack : IGenericCollections
    {
        Stack<MyModel> stackGeneric = new Stack<MyModel>();
        Stopwatch stopwatch = new();

        public void GetCollection()
        {
            stopwatch.Start();
            for (int i = 0; i < 200; i++)
            {
                stackGeneric.Push(new MyModel() { Name = "Enes", SurName = "Yıldırım", EMail = "xyz@gmail.com", Password = "xyz123", Counter = i + 99 });
            }
            stopwatch.Stop();
            Console.WriteLine("Geçen Zaman= " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();

        }
    }
    public class MyModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public int Counter { get; set; }
    }
}
