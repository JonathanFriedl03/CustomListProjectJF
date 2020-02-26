using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Project_JF;
namespace Cutom_List_Project_Test
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ToString_NumberList_NewString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            string expected = "98765";

            //Act
            myList.Add(9);
            myList.Add(8);
            myList.Add(7);
            myList.Add(65);

            //Assert
            Assert.AreEqual(expected, myList.ToString());
        }

        [TestMethod]
        public void ToString_StringList_NewString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expected = "Greatness Awaits";

            //Act
            myList.Add("Greatness");
            myList.Add(" ");
            myList.Add("Awaits");

            //Assert
            Assert.AreEqual(expected, myList.ToString());
        }

        [TestMethod]
        public void ToString_EmptyList_NewString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            string expected = "";
            //Act

            //Assert
            Assert.AreEqual(expected, myList.ToString());
        }



        [TestMethod]
        public void Add_IntLists_CaptureResult()
        {
            //Arrange
            CustomList<int> numbersListOne = new CustomList<int>();
            CustomList<int> numbersListTwo = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            expected.Add(9);
            expected.Add(8);
            expected.Add(7);
            expected.Add(6);
            expected.Add(5);
            expected.Add(4);

            //Act
            numbersListOne.Add(9);
            numbersListOne.Add(8);
            numbersListOne.Add(7);
            numbersListTwo.Add(6);
            numbersListTwo.Add(5);
            numbersListTwo.Add(4);
            resultList = numbersListOne + numbersListTwo;

           Assert.AreEqual(expected.ToString(), resultList.ToString());
           
        }
        [TestMethod]
        public void Add_StringLists_CaptureResult()
        {
            //Arrange
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            CustomList<string> resultList = new CustomList<string>();
            CustomList<string> expected = new CustomList<string>();
            expected.Add("J");
            expected.Add("O");
            expected.Add("N");
            expected.Add("A");
            expected.Add("T");
            expected.Add("H");
            expected.Add("A");
            expected.Add("N");


            //Act
            stringListOne.Add("J");
            stringListOne.Add("O");
            stringListOne.Add("N");
            stringListOne.Add("A");
            stringListTwo.Add("T");
            stringListTwo.Add("H");
            stringListTwo.Add("A");
            stringListTwo.Add("N");
            resultList = stringListOne + stringListTwo;

            //Assert
            Assert.AreEqual(expected.ToString(), resultList.ToString());
        }
        [TestMethod]
        public void Add_EmptyLists_CaptureResult()
        {
            //Arrange
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            CustomList<string> resultList = new CustomList<string>();
            CustomList<string> expected = new CustomList<string>();

            //Act
            resultList = stringListOne + stringListTwo;

            //Assert
            Assert.AreEqual(expected.ToString(), resultList.ToString());
        }
    }
}
