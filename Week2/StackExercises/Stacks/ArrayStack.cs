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
            return stack[pointer - 1];
        }

        public T pop()
        {
            return stack[--pointer];
        }

        public void push(T item)
        {
            stack[pointer++] = item;
        }

        public bool isEmpty() {
            return stack.Length <= 0;
        }
    }
}