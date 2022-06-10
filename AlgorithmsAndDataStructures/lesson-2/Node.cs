using System;

namespace lesson_2
{
    public class Node : ILinkedList
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        private Node head = new Node();
        private Node tail = new Node();

        public Node()
        {
            head.NextNode = tail;
            tail.PrevNode = head;
        }

        /// <summary>
        /// Возвращает количество элементов в списке.
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            int count = 0;
            Node current = head.NextNode;
            while (current != tail)
            {
                current = current.NextNode;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Добавляет новый элемент списка.
        /// </summary>
        /// <param name="value"> Значение элемента. </param>
        public void AddNode(int value)
        {
            tail.PrevNode = new()
            {
                Value = value,
                PrevNode = tail.PrevNode
            };
        }

        /// <summary>
        /// Добавляет новый элемент списка после определённого элемента.
        /// </summary>
        /// <param name="node"> Имя элемента. </param>
        /// <param name="value"> Значение элемента. </param>
        /// <exception cref="ArgumentException"></exception>
        public void AddNodeAfter(Node node, int value)
        {
            Node current = head.NextNode;
            while (current != tail && current != node)
            {
                current = current.NextNode;
            }
            if (current != tail)
            {
                current.NextNode = new()
                {
                    Value = value,
                    PrevNode = current,
                    NextNode = current.NextNode
                };
            }
            else
            {
                throw new ArgumentException("Данной ноды нет в списке.", nameof(node));
            }
        }

        /// <summary>
        /// Удаляет элемент по порядковому номеру.
        /// </summary>
        /// <param name="index"> Индекс. </param>
        /// <exception cref="ArgumentException"></exception>
        public void RemoveNode(int index)
        {
            int count = 0;
            Node current = head.NextNode;
            while (current != tail && count < index)
            {
                current = current.NextNode;
                count++;
            }
            if (count == index)
            {
                RemoveNode(current);
            }
            else
            {
                throw new ArgumentException("Ноды с таким индексом нет в списке.", nameof(index));
            }
        }

        /// <summary>
        /// Удаляет указанный элемент.
        /// </summary>
        /// <param name="node"> Имя элемента. </param>
        public void RemoveNode(Node node)
        {
            Node next = node.NextNode;
            Node prev = node.PrevNode;
            next.PrevNode = prev;
            prev.NextNode = next;
        }

        /// <summary>
        /// Ищет элемент по его значению.
        /// </summary>
        /// <param name="searchValue"> Искомое значение. </param>
        /// <returns></returns>
        public Node FindNode(int searchValue)
        {
            Node current = head.NextNode;
            while (current != tail && current.Value != searchValue)
            {
                current = current.NextNode;
            }
            if (current != tail)
            {
                return current;
            }
            else
            {
                return null;
            }
        }
    }
}
