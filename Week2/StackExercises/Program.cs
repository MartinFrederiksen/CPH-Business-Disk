using System;

namespace StackExercises.Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===ArrayStack Tests===");
            ArrayStack<int> arrayStack = new ArrayStack<int>(10);
            arrayStack.push(2);
            arrayStack.push(3);
            arrayStack.push(15);
            arrayStack.push(17);
            Console.WriteLine(arrayStack.pop());
            Console.WriteLine(arrayStack.peek());
            arrayStack.push(10);
                        
            Console.WriteLine("===All Elements From ArrayStack===");
            foreach (var item in arrayStack.stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===LinkedStack Tests===");
            LinkedStack<int> linkedStack = new LinkedStack<int>();
            linkedStack.push(2);
            Console.WriteLine(linkedStack.peek());
            Console.WriteLine(linkedStack.pop());
            linkedStack.push(3);
            linkedStack.push(15);
            linkedStack.push(17);
            Console.WriteLine(linkedStack.peek());
            Console.WriteLine(linkedStack.pop());
            Console.WriteLine(linkedStack.peek());
        }
    }
}