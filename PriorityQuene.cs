using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class PriorityQuene : ICollection<Item>
    {
        private Item first;

        private int Criticals = 0;
        private int Highs = 0;
        private int Normals = 0;
        private int Lows = 0;


        public int Critical { get { return Criticals; } }
        public int High { get { return Highs; } }
        public int Normal { get { return Normals; } }
        public int Low { get { return Lows; } }

        public int Count
        {
            get
            {
                int c = 0;
                Item current = first;
                while (current != null)
                {
                    c++;
                    current = current.Next;
                }
                return c;
            }
        }

        public bool IsReadOnly
        { get { return false; } }

        public void Enqueue(Item item)
        {
            switch (item.Priority)
            {
                case Priority.Critical:
                    Criticals += 1;
                    break;
                case Priority.High:
                    Highs += 1;
                    break;
                case Priority.Normal:
                    Normals += 1;
                    break;
                case Priority.Low:
                    Lows += 1;
                    break;
            }

            if (first == null)
            {
                first = item;
            }
            else
            {
                if (item.Priority < first.Priority)
                {
                    item.Next = first;
                    first = item;
                }
                else
                {
                    if (first.Next == null)
                        first.Next = item;
                    else
                    {
                        Item next = first.Next;
                        Item last = null;
                        while(next != null)
                        {
                            if (item.Priority < next.Priority)
                            {
                                item.Next = next;
                                if (last == null)
                                    first.Next = item;
                                else
                                    last.Next = item;
                                break;
                            }
                            last = next;
                            next = next.Next;
                        }
                        if (next == null)
                            last.Next = item;
                    }
                }
            }

        }

        public void Clear()
        {
            first = null;
            Criticals = 0;
            Highs = 0;
            Normals = 0;
            Lows = 0;

        }

        public bool Contains(Item item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Item[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Item> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Item Dequeue()
        {
            Item removed = first;

            switch (removed.Priority)
            {
                case Priority.Critical:
                    Criticals -= 1;
                    break;
                case Priority.High:
                    Highs -= 1;
                    break;
                case Priority.Normal:
                    Normals -= 1;
                    break;
                case Priority.Low:
                    Lows -= 1;
                    break;
            }

            first = first.Next;

            return removed;
            
        }

        public Item Peek()
        {
            return first;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Item item)
        {
            throw new NotImplementedException();
        }

        public void Add(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
