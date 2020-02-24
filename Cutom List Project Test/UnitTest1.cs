using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Project_JF;
namespace Cutom_List_Project_Test
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void Add_OneValue_CountIncrement()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;

            //Act
            myList.Add(5);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod]
        public void Add_MultipleValues_CountIncrements()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 3;

            //Act
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod] //Arrange
                     //Act
                     //Assert
        public void Add_Check_MaxCapacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;

            //Act
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);

            //Assert
            Assert.AreEqual(expected, myList.Capacity);
        }
        [TestMethod]
        public void Add_Check_NewMaxCapacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;
            //Act
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            //Assert
            Assert.AreEqual(expected, myList.Count);//should this also be .capacity?
        }
        [TestMethod]
        public void Add_ItemIsAt_SpecifiedIndicies()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;

            //Act
            myList.Add(expected);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Add_ItemRemainsAtSpecifiedIndicies_WithMultipleValues()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;
            int value1 = 5;
            int value2 = 10;
            //Act
            myList.Add(value1);
            myList.Add(value2);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
     
        [TestMethod]
        public void Add_IncreaseList_MaxCapacityIncrease_Copy()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
          
            //Act
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            //Assert
            Assert.AreEqual(expected, myList[0]);//capcity
        }
        [TestMethod]
        public void Remove_OneValue_CountRemaining()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 0;

            //Act
            myList.Add(5);
            myList.Remove(5);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod]
        public void Remove_ItemIsAt_SpecifiedIndicies()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Remove(5);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Remove_MultipleValues_CountRemaining()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;

            //Act
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            myList.Remove(5);
            myList.Remove(5);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod]
        public void Remove_MultipleValues_CorrectIndiciesRemoved()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 7;
            int expected2 = 8;

            //Act
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Remove(6);
            myList.Remove(5);

            //Assert
            Assert.AreEqual(expected, myList[0]);
            Assert.AreEqual(expected2, myList[1]);
        }        
        
        
        [TestMethod]
        public void Remove_ItemRemainsAtSpecifiedIndicies_WithMultipleTypes()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 20;
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

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }

        [TestMethod]
        public void Remove_InputNotInList_WontChangeAnything()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int value4 = 20;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Remove(100);

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void Remove_InputNotInList_WontChangeCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int value4 = 20;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Remove(100);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }

    }
    
}
