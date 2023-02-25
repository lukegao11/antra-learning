using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment4
{
    public class MyList<T>
    {
        private List<T> items;
        public MyList() {
            items = new List<T>();
        }

        void Add(T item)
        {
            items.Add(item);
        }

        void Clear()
        {
            items.Clear();
        }


        bool Contains(T item)
        {
            return items.Contains(item);
        }


        T Remove(int index)
        {
            T item = items[index];
            items.RemoveAt(index);
            return item;
        }

        void InsertAt(T element, int index)
        {
            items.Insert(index, element);
        }

        void DeleteAt(int index)
        {
            items.RemoveAt(index);
        }


        T Find(int index)
        {
            return items[index];
        }



    }
}
