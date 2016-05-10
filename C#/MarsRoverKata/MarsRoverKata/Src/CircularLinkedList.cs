using System.Collections.Generic;

namespace MarsRoverKata
{
    static class CircularLinkedList
    {
        public static LinkedListNode<char> NextOrFirst(
            this LinkedListNode<char> current) => 
                current.Next ?? current.List.First;

        public static LinkedListNode<char> PreviousOrLast(
            this LinkedListNode<char> current) => 
                current.Previous ?? current.List.Last;
    }
}
