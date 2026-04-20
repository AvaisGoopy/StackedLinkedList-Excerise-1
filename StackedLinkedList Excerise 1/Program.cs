namespace StackedLinkedList_Excerise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackLL s1 = new StackLL();


            s1.Push("Zara");
            s1.Push("Mahmood");
            s1.Push("Bob");
            s1.Push("Nat");
            s1.printAllNodes();
            Console.WriteLine("\nPop the List");
            s1.Pop();
            s1.printAllNodes();

            Console.WriteLine("\nPeek The list");
            Console.WriteLine("The top of the stack: " + s1.Peek());

            Console.WriteLine("\nSize of the stack: " + s1.Size());
 
            Console.WriteLine("\nReversed Stack: ");
            s1.ReverseStack();
            s1.printAllNodes();


            //,jsdljdvkljk
        }
    }
}
