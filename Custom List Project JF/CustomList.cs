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

        // array member variable
        //count, capcity and index properties google this one
        private T[] eachItemInArray;        
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
           int listCounter = GetLongerListCount(listA, listB);
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

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
        //static void alternateMerge(int[] arr1, int[] arr2,
        ////                    int n1, int n2, int[] arr3)
        //{
        //    int i = 0, j = 0, k = 0;

        //    // Traverse both array 
        //    while (i < n1 && j < n2)
        //    {
        //        arr3[k++] = arr1[i++];
        //        arr3[k++] = arr2[j++];
        //    }

        //    // Store remaining elements of first array 
        //    while (i < n1)
        //        arr3[k++] = arr1[i++];

        //    // Store remaining elements of second array 
        //    while (j < n2)
        //        arr3[k++] = arr2[j++];
        //}
        //public static void Main()
        //{
        //    int[] arr1 = new int[] { 1, 3, 5, 7, 9, 11 };
        //    int n1 = arr1.Length;

        //    int[] arr2 = new int[] { 2, 4, 6, 8 };
        //    int n2 = arr2.Length;

        //    int[] arr3 = new int[n1 + n2];
        //    alternateMerge(arr1, arr2, n1, n2, arr3);

        //    Console.WriteLine("Array after merging");
        //    for (int i = 0; i < n1 + n2; i++)
        //        Console.Write(arr3[i] + " ");
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