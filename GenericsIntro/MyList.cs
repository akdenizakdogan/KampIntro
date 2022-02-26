using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()     //ctor tabtab. constructor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //elemanlarım kaybolmasın diye gecici olarak baska bir array e tutturdum.
            items = new T[items.Length + 1]; //Dizinin eleman sayısını 1 arttırdım. 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // gecici diziye verdigim elemanları kendi dizime geri alıyorum.
            }

            items[items.Length - 1] = item; // asıl eklenmek istenen elemanı şu an ekleyebildin.

        }
    }
}
