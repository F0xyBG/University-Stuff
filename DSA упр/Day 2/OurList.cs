using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day2
{
    public class OurList
    {
        private object[] arr;

        private static readonly int INITIAL_CAPACITY = 4;

        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public OurList()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }


        public void Insert(int index, object item)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }


            object[] extendedArray = arr;

            if (arr.Length == count + 1)
            {
                extendedArray = new object[arr.Length * 2];
            }

            Array.Copy(arr, extendedArray, index);
            count++;
            Array.Copy(arr, index, extendedArray, index + 1, count - index - 1);
            extendedArray[index] = item;
            arr = extendedArray;
        }

        public void Add(object item)
        {
            Insert(count, item);
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (item.Equals(arr[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (item.Equals(arr[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public object Remove(int index)
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            object item = arr[index];

            Array.Copy(arr, index + 1, arr, index, count - index - 1);
            arr[count - 1] = null;
            count--;

            return item;
        }

        public int Remove(object item)
        {
            int index = IndexOf(item);

            Remove(index);

            return index;
        }


        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }

                return arr[index];
            }

            set
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }

                arr[index] = value;

            }
        }


        public void PrintList()
        {
            Console.WriteLine("----------------------------");
            for (int i = 0; i < count; i++)
            {
                
                Console.WriteLine(arr[i]);
                
            }
            Console.WriteLine("----------------------------");
        }
    //     private object[] items = new object[1];
    //     private int count = 0;

    //     public void Add(object item)
    //     {
    //         if (count == items.Length)
    //         {
    //             object[] newItems = new object[items.Length * 2];
    //             Array.Copy(items, newItems, items.Length);
    //             items = newItems;
    //         }

    //         items[count] = item;
    //         count++;
    //     }

    //     public object Remove(int index)
    //     {
    //         if (index < 0 || index >= count)
    //         {
    //             throw new IndexOutOfRangeException();
    //         }

    //         object item = items[index];
    //         Array.Copy(items, index + 1, items, index, count - index - 1);
    //         count--;

    //         return item;
    //     }

    //     public object Remove(object item)
    //     {
    //         int index = items.

    //         if (index == -1)
    //         {
    //             throw new ArgumentException();
    //         }

    //         return Remove(index);
    //     }
        
    }
}