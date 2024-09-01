using System.Xml.Linq;

namespace sort
{


    internal class Program
    {
        static void Main(string[] args)
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.PrintAllNodes();
            list.AddLast(0);
            list.PrintAllNodes();
            list.AddLast(1);
            list.AddLast(5);
            list.PrintAllNodes();
            list.AddFirst(-1);
            list.PrintAllNodes();
            int[] arr = { list.RemoveLast(), list.RemoveFirst(), list.RemoveFirst(), list.RemoveLast() };
            list.PrintAllNodes();
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();

            Sorts.SelectionSort(arr);
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
