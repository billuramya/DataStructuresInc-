//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace linkedList_tutorial
//{
   

//    public class Stack
//    {
//        private int[] array;
//        private int top;
//        private int capacity;

//        public Stack(int size)
//        {
//            array = new int[size];
//            capacity = size;
//            top = -1;
//        }

//        public void Push(int item)
//        {
//            if (top == capacity - 1)
//            {
//                Console.WriteLine("Stack Overflow. Cannot push {0}.", item);
//                return;
//            }

//            array[++top] = item;
//            Console.WriteLine("{0} pushed to the stack.", item);
//        }

//        public int Pop()
//        {
//            if (top == -1)
//            {
//                Console.WriteLine("Stack Underflow. Cannot pop from an empty stack.");
//                return -1; // Indicates stack underflow
//            }

//            int poppedItem = array[top--];
//            Console.WriteLine("{0} popped from the stack.", poppedItem);
//            return poppedItem;
//        }

//        public int Peek()
//        {
//            if (top == -1)
//            {
//                Console.WriteLine("Stack is empty.");
//                return -1; // Indicates stack is empty
//            }

//            return array[top];
//        }

//        public bool IsEmpty()
//        {
//            return top == -1;
//        }

//        public void PrintStack()
//        {
//            if (top == -1)
//            {
//                Console.WriteLine("Stack is empty.");
//                return;
//            }

//            Console.Write("Stack elements: ");
//            for (int i = 0; i <= top; i++)
//            {
//                Console.Write(array[i] + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Stack myStack = new Stack(5);

//            myStack.Push(1);
//            myStack.Push(2);
//            myStack.Push(3);
//            myStack.PrintStack();

//            int poppedItem = myStack.Pop();
//            Console.WriteLine("Popped item: {0}", poppedItem);

//            myStack.PrintStack();
//        }
//    }

//}
