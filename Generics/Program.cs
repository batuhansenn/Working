using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İzmir");
            sehirler.Add("Manisa");
            sehirler.Add("Uşak");
            sehirler.Add("Konya");
            sehirler.Add("Kayseri");
            sehirler.Add("Trobzon");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Yozgat");
            sehirler2.Add("Samsun");
            sehirler2.Add("Sinop");
            sehirler2.Add("Adana");
            sehirler2.Add("İstanbul");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler.Count);


        }
    }
    class MyList<T> //Generic Class
    {
        T[] _arry;
        T[] _tempArry;
        public MyList()
        {
            _arry = new T[0];
        }
        public void Add(T item)
        {
            _tempArry = _arry;
            _arry = new T[_arry.Length + 1];
            for (int i = 0; i < _tempArry.Length; i++)
            {
                _arry[i] = _tempArry[i];
            }
        }

        public int Count
        {
            get { return _arry.Length; }
        }

    }
}
