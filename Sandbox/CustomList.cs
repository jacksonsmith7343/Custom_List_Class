using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T> where T : IEnumerator
    {
        private T[] items;
        private int count;

        private int capacity;


        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
            CustomList<T>  = CustomList<T>();
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
        //increase the capacity of your inner array when count becomes equal to capacity
        //do a check for this
        //increase the capacity times 2
        //create a temporary array be set to the new capacity
        //take each value one by one from your original array and put them into the new temp array
        //set your original array equal to the new temp array

        // 50 30 45 12 40 null null null
        // r/30
        // 50 30 45 12 40 null null null


        //30 45 12 40 null null null null
        public void Remove(T item)
        {
            bool hasBeenFound = false;
            for (int i = 0; i < count; i++)
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
        //items[i].Equals(item)

        //30 12 45 70 12 null null null
        //Remove(12)
        //
        //30 45 70 12 null null null null



        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return CustomList<T>;
            }
        }








    }
}
