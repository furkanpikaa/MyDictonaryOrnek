using System;
using System.Collections.Generic;

namespace MyDictonaryOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int,string> myList = new MyList<int,string>();
            myList.Add(1,"Ocak");
            myList.Add(2, "Şubat");
            myList.Add(3, "Mart");
            myList.Add(4, "Nisan");
            myList.Add(5, "Mayıs");
            myList.Add(6, "Haziran");
            myList.Add(7, "Temmuz");
            myList.Add(8, "Ağustos");
            myList.Add(9, "Eylül");
            myList.Add(10, "Ekim");
            myList.Add(11, "Kasım");
            myList.Add(12, "Aralık");

            foreach (MyKeyValue<int,string> x in myList) 
            {
                Console.WriteLine("Ayın Değeri {0} " + " " + "Ayın ismi {1}",x.Key , x.Value);
            }

            Console.ReadLine();
        }
    }

    public class MyKeyValue<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    public class MyList<TKey, TValue>
    {
        private MyKeyValue<TKey, TValue>[] items;

        public MyList()
        {
            items = new MyKeyValue<TKey, TValue>[0];
        }

        public void Add(TKey key, TValue value) 
        {
            MyKeyValue<TKey, TValue>[] tempItems = items;
            items = new MyKeyValue<TKey, TValue>[items.Length + 1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

            items[items.Length-1] = new MyKeyValue<TKey, TValue> { Key = key, Value = value };
        }


        public IEnumerator<MyKeyValue<TKey, TValue>> GetEnumerator()
        {
            foreach (MyKeyValue<TKey, TValue> a in items)
            {
                yield return a;
            }
        }

    }
}
