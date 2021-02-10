using System;

namespace StackExercises.Stacks
{
    public class ArrayStack<T> : IStack<T>
    {
        public T[] stack;
        int pointer = 0;
        public ArrayStack(int size)
        {
            stack = new T[size];
        }

        public T peek()
        {
            isEmpty();
            return stack[pointer - 1];
        }

        public T pop()
        {
            isEmpty();
            return stack[--pointer];
        }

        public void push(T item)
        {
            stack[pointer++] = item;
        }

        public void isEmpty() {
            if(stack.Length <= 0) throw new IndexOutOfRangeException();
        }
    }
}