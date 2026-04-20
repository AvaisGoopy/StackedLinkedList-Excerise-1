using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackedLinkedList_Excerise_1
{
    //internal interface IMember
    //{
    //    /// <summary>
    //    /// Adds value to list appropriately for a stack
    //    /// </summary>
    //    /// <param name="value"></param>
    //    public void Push(int value);

    //    public int Pop();

    //    public bool IsEmpty();

    //    int Size();

    //    public object Peek();

    //}

     interface IMember
    {
        /// <summary>
        /// Adds value to list appropriately for a stack Push(string value)
        /// <paramref name="value"/>
        /// </summary>
       
       
        public void Push(string value);


        /// <summary>
        /// Removes a value from the list appropriately for a stack
        /// </summary>
        /// <param name="value"></param>


        public int Pop();    //pop off the stack

        public bool IsEmpty();    //test to see if the stack is empty

        int Size();  //returns the size (number of elements) in the stack

        public string Peek();  //prints the top of the stack

    }
}
