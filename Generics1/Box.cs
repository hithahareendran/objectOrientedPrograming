using System;
using System.Collections.Generic;
using System.Text;

namespace Generics1
{
    class Box<T>
    {
        private List<T> elements = new List<T>();
        public int count { get; set; } 
        public void Add(T element)
        {
            elements.Add(element);
            count++;
        }
        public T Remove()
        {
            var defaultValue = default(T);
            if(count>0)
            {
                T value = elements[elements.Count - 1];
                count--;
                elements.RemoveAt(elements.Count - 1);
                return value;
            }
            return defaultValue;
        }
    }
}
