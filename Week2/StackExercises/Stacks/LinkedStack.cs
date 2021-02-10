namespace StackExercises.Stacks
{
    public class LinkedStack<T> : IStack<T>
    {
        Node top;

        private class Node
        {
            public T value;
            public Node next;
            
            public Node(T value, Node next)
            {
                this.value = value;
                this.next = next;
            }
        }

        public T peek()
        {
            isEmpty();
            return top.value;
        }

        public T pop()
        {
            isEmpty();
            T val = top.value;
            top = top.next;
            return val;
        }

        public void push(T item)
        {
            top = new Node(item, top);
        }

        public bool isEmpty(){
            return top == null;
        }
    }
}