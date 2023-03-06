using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExample
{
    internal class IntegerLinkedList
    {
        private IntegerNode? _head;
        private IntegerNode? _tail;

        private int _length = 0;
        private int _min = int.MaxValue;
        private int _max = int.MinValue;
        public int Length { get { return _length; } }
        public int Min { get { return _min; } }
        public int Max { get { return _max; } }

        public void Append(int value)
        {
            if (_head == null)
            {
                _head = new(value);
            }
            else
            {
                IntegerNode newNode = new(value);

                _tail ??= _head;

                _tail.Next = newNode;
                _tail = newNode;
            }

            _length++;
            if (value > _max) _max = value;
            if (value < _min) _min = value;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.Append("IntegerLinkedList: [");

            for (IntegerNode? node= _head; node!=null; node = node.Next)
            {
                builder.Append(node.Value);
                if (node.Next != null) builder.Append(", ");
            }

            builder.Append(']');

            return builder.ToString();
        }
    }

    internal class IntegerNode
    {
        private int _value;
        private IntegerNode? _next;

        public IntegerNode(int value)
        {
            _value = value;
        }

        public int Value { get { return _value; } set {  _value = value; } }
        public IntegerNode? Next { get { return _next; } set { _next = value; } }
    }
}
