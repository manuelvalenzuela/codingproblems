using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Threading.Tasks.Dataflow;
using CodingProblems;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // to execute in case Unit Tests aren't enough

            var cache = new LRUCache(1);
            cache.Put(2, 1);
            cache.Get(1);   // returns 1

            System.Console.ReadLine();
        }
    }
}