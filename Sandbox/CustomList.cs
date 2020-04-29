using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;

        private int capacity;


        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
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

            //items[count] = item;





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
            else 
            {
                items[count] = item;
                count++;
            }
            
        }
        //increase the capacity of your inner array when count becomes equal to capacity
        //do a check for this
        //increase the capacity times 2
        //create a temporary array be set to the new capacity
        //take each value one by one from your original array and put them into the new temp array
        //set your original array equal to the new temp array

        public void Remove(T item)
        {
            items[count] = item;
            count--;
        }

        






    }
}
