using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project_JF
{
    public class CustomList<T>
    {

        // array member variable
        //count, capcity and index propertiesgoogle this one
        private T[] itemsInArray;
        CustomList<int> customList;
        private int count;
        private int capacity;
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
            //set
            //{
            //    capacity = value;
            //}
        }
        //T capacity = 4;


        //constructor  
        public CustomList()
        {
            itemsInArray = new T[4];
            count = 0;
        }
        public void Add(T itemPassed)
        {
            CustomList<int> customList = new CustomList<int>();
            itemsInArray[0] = itemPassed;
           // count++;

            //increment count

            //item needs to land at next available index

            //check to make sure it persists

            //count == maxcapacity, we need to increase capacity and copy
            
        }



    }
}


   

