namespace sort
{
    internal interface ILinkedList<T>
    {
        void PrintAllNodes();
        void AddFirst(T data);
        void AddLast(T data);
        T? RemoveFirst();
        T? RemoveLast();
    }
    internal class LinkedList<T> : ILinkedList<T>
    {
        private Node<T>? head { get; set; }
        private Node<T>? tail { get; set; }
        private int count { get; set; } = 0;

        public void PrintAllNodes()
        {
            var current = head;
            while (current != null)
            {
                Console.Write($"{current.data} ");
                current = current.next;
            }
            Console.WriteLine();
        }

        public void AddFirst(T data)
        {
            var toAdd = new Node<T>();
            toAdd.data = data;
            toAdd.next = null;
            switch (count)
            {
                case 0:
                    {
                        head = toAdd;
                        tail = head;
                        break;
                    }
                case 1:
                    {
                        toAdd.next = head;
                        head = toAdd;
                        tail = head.next;
                        break;
                    }
                default:
                    {
                        toAdd.next = head;
                        head = toAdd;
                        break;
                    }
            }
            count++;
        }

        public void AddLast(T data)
        {
            var toAdd = new Node<T>();
            toAdd.data = data;
            toAdd.next = null;
            switch (count)
            {
                case 0:
                    {
                        head = toAdd;
                        tail = head;
                        break;
                    }
                case 1:
                    {
                        head.next = toAdd;
                        tail = head.next;
                        break;
                    }
                default:
                    {
                        tail.next = toAdd;
                        tail=tail.next;
                        break;
                    }
            }
            count++;
        }
        public T? RemoveFirst()
        {
            switch (count)
            {
                case 0: throw new InvalidOperationException();
                case 1:
                    {
                        var toRemove = head.data;
                        head = tail = null;
                        count--;
                        return toRemove;
                    }
                default:
                    {
                        var toRemove = head.data;
                        head = head.next;
                        count--;
                        return toRemove;
                    }
            }
        }
        public T? RemoveLast()
        {
            switch (count)
            {
                case 0:
                    throw new InvalidOperationException();
                case 1:
                    {
                        var toRemove = head.data;
                        head = tail = null;
                        count--;
                        return toRemove;
                    }
                case 2:
                    {
                        var toRemove = tail.data;
                        tail = head;
                        tail.next = null;
                        count--;
                        return toRemove;
                    }
                default:
                    {
                        var toRemove = tail.data;
                        var current = head;
                        while (current!.next!.next != null)
                        {
                            current = current.next;
                        }
                        tail = current;
                        tail.next = null;
                        count--;
                        return toRemove;
                    }
            }
        }
        public void Set(int index, T value)
        {
            if (count < index)
            {
                throw new IndexOutOfRangeException();
            }
            var current = head;
            int i = 0;
            while (current != null)
            {
                var next = current.next;
                i++;
                if (i == index)
                {
                    current.data = value;
                }
            }
        }
        public T Get(int index)
        {
            if (count < index)
            {
                throw new IndexOutOfRangeException();
            }
            var current = head;
            int i = 0;
            while (current != null)
            {
                var next = current.next;
                i++;
                if (i == index)
                {
                    return current.data;
                }
            }
            throw new IndexOutOfRangeException();
        }
    
        public T? RemoveAt(int index)
        {
            if (count < index)
            {
                throw new IndexOutOfRangeException();
            }
            var current = head;
            int i = 0;
            while (current != null)
            {
                var next = current.next;
                i++;
                if (i == index)
                {
                    T toRemove = current.data;
                    current = current.next;
                    if (current.next == null)
                        tail = current;
                    return toRemove;
                }
            }
            throw new IndexOutOfRangeException();
        }
    }
}
