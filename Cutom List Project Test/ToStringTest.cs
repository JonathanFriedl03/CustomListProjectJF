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



        //[TestMethod]
        //public void Add_IntLists_CaptureResult()
        //{
        //    //Arrange
        //    CustomList<int> numberListOne = new CustomList<int>();
        //    CustomList<int> numberListTwo = new CustomList<int>();
        //    CustomList<int> resultList = new CustomList<int>();
        //    CustomList<int> expected = new CustomList<int>();
        //    expected.Add(9);
        //    expected.Add(8);
        //    expected.Add(7);
        //    expected.Add(6);
        //    expected.Add(5);
        //    expected.Add(4);

        //    //Act
        //    numberListOne.Add(9);
        //    numberListOne.Add(8);
        //    numberListOne.Add(7);
        //    numberListTwo.Add(6);
        //    numberListTwo.Add(5);
        //    numberListTwo.Add(4);
        //    resultList = numberListOne + numberListTwo;

        //Assert
        //    Assert.AreEqual(expected, resultList);
        //}
        //[TestMethod]
        //public void Add_StringLists_CaptureResult()
        //{
        //    //Arrange
        //    CustomList<string> stringListOne = new CustomList<string>();
        //    CustomList<string> stringListTwo = new CustomList<string>();
        //    CustomList<string> resultList = new CustomList<string>();
        //    CustomList<string> expected = new CustomList<string>();
        //    expected.Add("J");
        //    expected.Add("O");
        //    expected.Add("N");


        //    //Act
        //    stringListOne.Add("J");
        //    stringListOne.Add("O");
        //    stringListTwo.Add("N");
        //    resultList = stringListOne + stringListTwo;

        //    //Assert
        //    Assert.AreEqual(expected, resultList);
        //}
        //[TestMethod]
        //public void Add_EmptyLists_CaptureResult()
        //{
        //    //Arrange
        //    CustomList<string> stringListOne = new CustomList<string>();
        //    CustomList<string> stringListTwo = new CustomList<string>();
        //    CustomList<string> resultList = new CustomList<string>();
        //    CustomList<string> expected = new CustomList<string>();

        //    //Act
        //    resultList = stringListOne + stringListTwo;

        //    //Assert
        //    Assert.AreEqual(expected, resultList);
        //}
        }   
    }
