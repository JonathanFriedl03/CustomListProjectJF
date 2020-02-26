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



        // C# how to overload an operator
        // CustomList<int> result = list1 + list2;
        public void Remove(T itemPassed)        
        {            
            tempArray = new T[capacity];
            bool itemFound = false;

            for (int i = 0; i < count; i++)
            {
                if (eachItemInArray[i].Equals(itemPassed))
                {                 
                   itemFound = true;                   
                }
               
                if (itemFound && !(i == count -1))
                {
                    tempArray[i] = eachItemInArray[i + 1];
                    
                }
               else if (!eachItemInArray[i].Equals(itemPassed))
                {                   
                    tempArray[i] = eachItemInArray[i];              
                
                }
            }
            
            if (itemFound == true)
            {
                count--;
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
        //public string ToString()
        //{
        //    string convertString = "";
        //    for (int i = 0; i < count; i++)
        //    {
        //        convertString += eachItemInArray[i].ToString();
        //    }
        //    return convertString;
        //}


    }
}








//public void RemoveMIKE(T itemPassed)
//{
//    tempArray = new T[capacity];
//    bool itemFound = false;

//    for (int i = 0; i < count - 1; i++)
//    {
//        if (eachItemInArray[i].Equals(itemPassed))
//        {
//            itemFound = true;
//        }
//        else if (!eachItemInArray[i].Equals(itemPassed))
//        {
//            if(itemFound)
//            {
//                tempArray[i] = eachItemInArray[i + 1];
//            }
//            else
//            {
//                tempArray[i] = eachItemInArray[i];
//            }

//            // itemFound = false;
//        }


//        //else if (!eachItemInArray[i].Equals(itemPassed) && itemFound)
//        //{
//        //    tempArray[i] = eachItemInArray[i + 1];
//        //    // itemFound = false;
//        //}
//        //else if (!eachItemInArray[i].Equals(itemPassed) && !itemFound)
//        //{

//        //    tempArray[i] = eachItemInArray[i];


//        //}

//    }
//    count--;
//    eachItemInArray = tempArray;
//}