using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Item : IEquatable<Item>
    {
        private string name;
        private Item next;

        private Priority priority;

        public Priority Priority
        {
            get { return priority; }
            set { priority = value; }
        }


        public string Name { get { return name; } }
        public Item Next
        {
            get { return next; }
            set { next = value; }
        }

        public Item(string n, Priority p)
        {
            name = n;
            priority = p;
            next = null;
        }

        public bool Equals(Item other)
        {
            return (this.name == other.name && this.priority == other.priority);
        }
    }


    public enum Priority
    {
        Critical = 0,
        High = 1,
        Normal = 2,
        Low = 3
    }
}
