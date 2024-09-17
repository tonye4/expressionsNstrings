using System;
namespace Expressions___Strings
{
    public class MyString : ICloneable, IComparable
    {
        private class Node
        {
            public char item;
            public Node next;


            // Constructor 
            public Node()
            {

            }

        }

        private Node front; // Reference to the first (header) node
        private int length; // Number of characters


        // Initialize an instance of MyString based on the given character array A 
        public MyString(char[] A)
        {

        }

        // Create and return a clone of the current instance 
        public object Clone()
        {

        }

        // Compare the current instance of MyString with obj and return a -1, 0 or +1
        // if the current string comes before, at or after obj in alphabetical order 
        public int CompareTo(object obj)
        {

        }

        // Return the index of the first occurrence of c; otherwise return -1 
        public int IndexOf(char c)
        {

        }

        // Remove all occurrences of c 
        public void Remove(char c)
        {

        }

        // Return true if obj is both of type MyString and the same as the current instance;
        // otherwise return false 
        // Hint: Use CompareTo
        public override bool Equals(object obj)
        {

        }

        // Print the current instance of MyString 
        public void Print()
        {

        }
    }
}
