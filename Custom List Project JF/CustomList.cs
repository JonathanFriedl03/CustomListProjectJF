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
        //count, capcity and index properties google this one
        private T[] eachItemInArray;
        private T[] tempArray;
        //CustomList<int> myList;
        private int count;//count property
        private int capacity;
        public T this[int index]
        {
            get
            {
                return eachItemInArray[index];
            }

            set
            {
                eachItemInArray[index] = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity//capacity property
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
        //T capacity = 4;//need it to grow after 4 is hit


        //constructor  
        public CustomList()
        {
            capacity = 4;
            eachItemInArray = new T[capacity];
            count = 0;
            
        }
        public void Add(T itemPassedIn)
        {
            //CustomList<int> myList
            //    = new CustomList<int>();
            if (count == capacity)
            {
                //move values to
                //make original bigger 
                //move values back
                capacity *= 2;
                tempArray = new T[capacity]; //make temp array bigger          
                
                
                for (int i = 0; i < count; i++)
                {
                     tempArray[i]= eachItemInArray[i];
                }
                eachItemInArray = tempArray;
                eachItemInArray[count] = itemPassedIn;
                count++;
                //move values to
                //make original bigger 
                //move values back

            }
            else
            {
                eachItemInArray[count] = itemPassedIn;
                count++;

            }
           
        }
        public void Remove(T itemPassed)
        {
            
            tempArray = new T[capacity];
            //eachItemInArray[count];
            for (int i = 0, j = 0; i <= count; i++, j++)
            {
                if (eachItemInArray[i].Equals(itemPassed))
                {

                    j--;
                    
                    
                }

                else
                {
                    tempArray[j] = eachItemInArray[i];

                }


            }
            eachItemInArray = tempArray;
            


            //}
            //eachItemInArray = tempArray;

            //eachItemInArray = tempArray;
            //eachItemInArray[count] = itemPassedIn;
            //count++;
            //if (eachItemInArray[i].Equals(itemPassed))
            //{
            //    for (int j = i; j < count; j++)
            //    {
            //        eachItemInArray[j] = eachItemInArray[i + 1];                    

            //    }
            //}


        }
        //public void ToString(T valuePassedIn)
        //{

        //}


    }
}


   

