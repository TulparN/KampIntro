using System;
using System.Collections.Generic;

namespace Dictionary_Odev_
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(0, "a");

            foreach (var item in myDictionary.Keys)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    class MyDictionary<K, V>
    {

        K[] items1;
        V[] items2;

        public MyDictionary()
        {
            items1 = new K[0];
            items2 = new V[0];
        }

        public void Add(K key, V value)
        {
            items1 = new K[items1.Length+1];
            items2 = new V[items2.Length + 1];

            K[] _tempKeyArray = items1;
            V[] _tempValueArray = items2;
            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _tempKeyArray[i] = items1[i];
                _tempValueArray[i] = items2[i];
            }

            items1[items1.Length - 1] = key;
            items2[items2.Length - 1] = value;


        }


        public K[] Keys
        {
            get { return items1; }

        }
        public V[] Values
        {
            get { return items2; }
        }


    }

}

