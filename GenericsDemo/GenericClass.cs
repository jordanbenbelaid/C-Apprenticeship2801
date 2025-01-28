using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class GenericClass<T>
    {

        private T item;

        public GenericClass(T item) 
        {
            this.item = item;
        }

        public T GetItem()
        {
            return item;
        }

        public void SetItem(T item)
        {
            this.item = item;
        }

        public override string ToString()
        {
            return "Generic Box - item = " + item;
        }
    }
}
