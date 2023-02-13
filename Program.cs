using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsMyList
{
    class MyList<T>
    {
        protected List<T> arrayList = new List<T>();

        public void AddElement(T t)
        {
            arrayList.Add(t);
        }

        public T Indexer(int index)
        {
            if (this.Count < index)
            {
                Console.WriteLine("The index was more than MyList has elements");
                throw new Exception();
            }
            return arrayList[index - 1];
        }

        public int Count
        {
            get { return arrayList.Count; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<object>();

            myList.AddElement("Hello");
            myList.AddElement(1);
            myList.AddElement("What is your name?");

            Console.WriteLine(myList.Count);
            Console.WriteLine(myList.Indexer(2));
            Console.WriteLine();

        }
    }
}



