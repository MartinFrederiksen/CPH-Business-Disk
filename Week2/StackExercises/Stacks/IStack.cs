namespace StackExercises.Stacks
{
    public interface IStack<T>
    {
        public void push(T item);
        public T pop();
        public T peek();
    }
}