using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    public class BoxGeneric<T>
    {
        private T item;

        public void SetItem(T value)
        {
            item = value;
        }

        public T GetItem()
        {
            return item;
        }
    }
}
