using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList_tutorial
{
    class Queue
    {
        static void Main()
        {
            
            Queue<int> myQueue = new Queue<int>();

            
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            
            int frontElement = myQueue.Dequeue();
            Console.WriteLine($"Dequeued element: {frontElement}");

            
            int peekedElement = myQueue.Peek();
            Console.WriteLine($"Peeked element: {peekedElement}");

            
            bool containsElement = myQueue.Contains(2);
            Console.WriteLine($"Does the queue contain 2? {containsElement}");

            
            myQueue.Clear();
            Console.WriteLine($"Queue is empty: {myQueue.Count == 0}");
        }
    }
}
