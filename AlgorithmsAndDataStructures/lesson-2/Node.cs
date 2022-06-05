using System;

namespace lesson_2
{
    public class Node : ILinkedList
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        /// <summary>
        /// Возвращает количество элементов в списке.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetCount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Добавляет новый элемент списка.
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddNode(int value)
        {
            
        }

        /// <summary>
        /// Добавляет новый элемент списка после определённого элемента.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаляет элемент по порядковому номеру.
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаляет указанный элемент.
        /// </summary>
        /// <param name="node"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ищет элемент по его значению.
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Node FindNode(int searchValue)
        {
            var currentNode = NextNode;
            while (currentNode != null)
            {
                currentNode.Value == searchValue ? return currentNode : currentNode == currentNode.NextItem;
            }
            return null;
        }
    }
}
