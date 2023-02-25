using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment4
{
    public class Mystack<T>
    {
        private List<T> items;
        public Mystack() {

            items = new List<T>();

        }
        int Count()
        {
            return items.Count;
        }



        T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }


        void Push(T item)
        {
            items.Add(item);
        }



    }
}
