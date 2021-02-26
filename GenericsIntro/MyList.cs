using System;

namespace GenericsIntro
{
     class MyList<T>
     { 
        private T[] items;

        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArrray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArrray.Length; i++)
            {
                items[i] = tempArrray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}