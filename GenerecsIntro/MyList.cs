using System;
using System.Collections.Generic;
using System.Text;

namespace GenerecsIntro
{
    class MyList<T>//1) veri tipi yazabilmek icin bu parantezi kullanman gerek T=Type demek strıng int genel adı
    {
        T[] items;//3)genericklaslar array dönderir metodun dısınde yaz tüm clasa erişsin  
        //constructor
        public MyList()//4)eleman sayısı olması için newlemek gerek, ctor iki kere taba bas ve 0 elemanlı newle
        {
            items = new T[0];
        }

        public void Add(T item)//2) parantez içi hangi tip istiyosan onu veriyorsun item=eleman
        {
            T[] tempArray = items; //6) geçiciDizi= her eleman sayını artırdıgında newlediğin için eski elemanlar kaybolur bu yuzden gecmiş dizinin referansını tutar
            items = new T[items.Length + 1];//5) 0 elemanlı dizinin eleman sayısını bir artırmak item.length mevcut eleman sayısı demek
            for (int i = 0; i < tempArray.Length; i++)//7) temparraye emanet ettiğn değerleri sırayla geri almak için 0 dan temparrayın sayısına kadar geri getirir
            {
                items[i] = tempArray[i]; //7)items ın i ninci elemanı temparrayın i ninci elemanı oldu geri alma işlemi yapıldı
            }


            items[items.Length - 1] = item;//8)son ekleyeceğin eleman için yer acmak 


        }

        public int Count//9) eleman sayısını görmek için eklemen gerek 
        {
            get { return items.Length; }
        }
    }
}
