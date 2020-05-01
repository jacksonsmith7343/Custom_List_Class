using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T> /*where T : IEnumerator*/
    {
        private T[] items;
        private int count;

        private int capacity;
        public string customList { get; set; };



        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
            //CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            //CustomList<int> two = new CustomList<int>() { 2, 4, 6 };


                

        }

        //public static CustomList operator + (CustomList customList1, CustomList customList2 )
        //{
        //    CustomList customListResult = new CustomList()
        //}


        //public IEnumerator GetEnumerator()
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        yield return CustomList<T>[index];
        //    }
        //}


        public override string ToString()
        {
            return this.CustomList;
        }



        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value >= 0)
                {

                }

            }
        }

        public void Add(T item)
        {

            if (count == capacity)
            {
                T[] tempArray = new T[capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    tempArray[i] = items[i];
                }
                items = new T[capacity *= 2];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];
                }
               
            }
            items[count] = item;
            count++;

        }
        
        public void Remove(T item)
        {
            bool hasBeenFound = false;
            for (int i = 0; i < count-1; i++)
            {
                if (items[i].Equals(item))
                {
                    hasBeenFound = true;
                }
                
                
                if (hasBeenFound == true)
                {
                    items[i] = items[i + 1];
                }
                
            }
            

        }
       
    //



    }
}
