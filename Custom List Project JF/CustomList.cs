using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Custom_List_Project_JF
{
    public class CustomList<T> : IEnumerable
    {
        //The zipper contains Easter Egg solid principle
        private T[] eachItemInArray;  
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
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return eachItemInArray[i];
            }
            
        }
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
                T[] tempArray = new T[capacity]; //make temp array bigger          
                
                
                for (int i = 0; i < count; i++)
                {
                   tempArray[i]= eachItemInArray[i];
                }
                eachItemInArray = tempArray;
                eachItemInArray[count] = itemPassedIn;
                count++;               
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
           T[] tempArray = new T[capacity];
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
            
        }
        public override string ToString()
        {
            string convertString = "";
            for (int i = 0; i < count; i++)
            {
                convertString += eachItemInArray[i].ToString();
            }
            return convertString;
        }
        public static CustomList<T> operator + (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < listOne.Count; i++)
            {
                newList.Add(listOne[i]);

            }
            for (int i = 0; i < listTwo.Count; i++)
            {
                newList.Add(listTwo[i]);
            }
            return newList;
        }


        public static CustomList<T> operator - (CustomList<T> listOne, CustomList<T> listTwo)
        {
            
            for (int i = 0; i < listTwo.Count; i++)
            {
                for (int j = 0; j < listOne.Count; j++)
                {
                    if (listTwo[i].Equals(listOne[j]))
                    {
                        listOne.Remove(listTwo[i]);
                        break;

                    }
                }               

            }
            return listOne;
        }
        public CustomList<T> Zipper(CustomList<T> listA, CustomList<T> listB)
        {
           int listCounter = GetLongerListCount(listA, listB);//This is a single responsibility principle so this method could be in here but since it does something other than Zip I created a new method
            CustomList<T> listC = new CustomList<T>();
            for (int i = 0; i < listCounter; i++)


            {
                if (i < listA.Count) 
                {
                    listC.Add(listA[i]);
                }
                if(i < listB.Count)
                {
                    listC.Add(listB[i]);
                }
                
            }
            return listC;
        }
        public int GetLongerListCount(CustomList<T> listOne, CustomList<T> listTwo)
        {
            int listCounter;
            if (listOne.Count > listTwo.Count)
            {
                listCounter = listOne.Count;
            }
            else
            {
                listCounter = listTwo.Count;
            }
            return listCounter;
        }

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