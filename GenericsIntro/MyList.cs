using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //type ın T si oraya her hangi bir değişken yada referans tipi yollaabilirim demek
    {
        T[] items;

        //constructor
        //classı newlersen bu otomatik çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //itemim programcı hangi tür de newlerse o türde olsun istediğimiz içi T koyduk
        {
            T[] tempArray = items;//geçici dizinin referansı itemsın referansı
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item;
        }
    }
}
