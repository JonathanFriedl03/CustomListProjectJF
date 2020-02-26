using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project_JF
{
    class Program
    {        
       static void Main(string[] args)
       {
            //CustomList<int> myList = new CustomList<int>();

            //myList.Add(5);
            //myList.Add(6);
            //myList.Add(7);
            //myList.Add(8);
            //myList.Add(9);
            //myList.Add(10);
            //myList.Remove(6); // we want: { 7, 8, 9, 10 };
            //myList.Remove(5);
            CustomList<int> myList = new CustomList<int>();
           
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int value4 = 20;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Remove(value3);
            myList.Remove(value2);

            //Act
           

        }

    }
}
