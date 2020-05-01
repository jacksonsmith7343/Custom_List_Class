using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;



namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////1
        [TestMethod]
        public void Add_AddingMultipleValuesToCustomList_CountOfCustomListIncrementsByAmountOfValuesAdded()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int secondItemToAdd = 12;
            int expected = 2;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(secondItemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        //2
        [TestMethod]
        public void Add_AddingTwoValuesToCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 14;
            int secondItemToAdd = 16;
            int expected = 16;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(secondItemToAdd);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        //3
        [TestMethod]
        public void Add_AddingFiveValuesToEmptyCustomList_LastValueGoesToFourthIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int firstItemToAdd = 12;
            int secondItemToAdd = 14;
            int thirdItemToAdd = 16;
            int fourthItemToAdd = 18;
            int fifthItemToAdd = 20;
            int expected = 20;
            int actual;

            // act
            testList.Add(firstItemToAdd);
            testList.Add(secondItemToAdd);
            testList.Add(thirdItemToAdd);
            testList.Add(fourthItemToAdd);
            testList.Add(fifthItemToAdd);
            actual = testList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
             //4
        [TestMethod]
        public void Add_AddingFiveValuesToEmptyCustomList_ListCapacityDoubles()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int firstItemToAdd = 12;
            int secondItemToAdd = 14;
            int thirdItemToAdd = 16;
            int fourthItemToAdd = 18;
            int fifthItemToAdd = 20;
            int expected = 8;
            int actual;

            // act
            testList.Add(firstItemToAdd);
            testList.Add(secondItemToAdd);
            testList.Add(thirdItemToAdd);
            testList.Add(fourthItemToAdd);
            testList.Add(fifthItemToAdd);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }
        //Remove test 1//////////////////////////////////////////
        [TestMethod]
        public void Remove_RemovingOneValueFromCustomList_CountOfCustomListDecrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 12;
            int itemToRemove =12;
            int expected = 0;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Remove(itemToRemove);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        //Remove test 2
        [TestMethod]
        public void Remove_RemovingFirstValueFromCustomListWithTwoValues_LastValueInCustomListMovesToZeroIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int secondItemToAdd = 12;
            int itemToRemove = 10;
            int expected = 12;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(secondItemToAdd);
            testList.Remove(itemToRemove);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        //Remove test 3
        [TestMethod]
        public void Remove_RemovingLastTwoValueFromCustomListWithThreeValues_ValueAtZeroIndexRemains()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int secondItemToAdd = 12;
            int thirdItemToAdd = 14;
            int itemToRemove = 14;
            int secondItemToRemove = 12;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(secondItemToAdd);
            testList.Add(thirdItemToAdd);
            testList.Remove(itemToRemove);
            testList.Remove(secondItemToRemove);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        //Remove test 4
        [TestMethod]
        public void Remove_RemovingFiveValuesFromCustomList_CapacityOfCustomListStaysTheSame()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int firstItemToAdd = 2;
            int secondItemToAdd = 4;
            int thirdItemToAdd = 6;
            int fourthItemToAdd = 8;
            int fifthItemToAdd = 10;

            int firstItemToRemove = 10;
            int secondItemToRemove = 8;
            int thirdItemToRemove = 6;
            int fourthItemToRemove = 4;
            int fifthItemToRemove = 2;
            int expected = 8;
            int actual;

            // act
            testList.Add(firstItemToAdd);
            testList.Add(secondItemToAdd);
            testList.Add(thirdItemToAdd);
            testList.Add(fourthItemToAdd);
            testList.Add(fifthItemToAdd);

            testList.Remove(firstItemToRemove);
            testList.Remove(secondItemToRemove);
            testList.Remove(thirdItemToRemove);
            testList.Remove(fourthItemToRemove);
            testList.Remove(fifthItemToRemove);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        //Remove test 5
        [TestMethod]
        public void Remove_RemovingOneValueAtTheTwoIndexInCustomList_ValueAtThreeIndexMovesToSecondIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int secondItemToAdd = 12;
            int thirdItemToAdd = 14;
            int fourthItemToAdd = 16;
            int itemToRemove = 14;
            int expected = 16;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(secondItemToAdd);
            testList.Add(thirdItemToAdd);
            testList.Add(fourthItemToAdd);
            testList.Remove(itemToRemove);
            actual = testList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        //Remove test 6
        [TestMethod]
        public void Remove_RemovingAnItemThatShowsUpInCustomListMultipleTimes_RemoveThatValueAtTheGreatestIndex()
        {
            
            //arange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 3;
            int secondItemToAdd = 3;
            int thirdItemToAdd = 4;
            int FourthItemToAdd = 5;
            int itemToRemove = 3;
            int expected = 3;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(secondItemToAdd);
            testList.Add(thirdItemToAdd);
            testList.Add(FourthItemToAdd);
            testList.Remove(itemToRemove);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Remove test 7
        [TestMethod]
        public void Remove_RemovingAnItemThatIsNotInTheCustomList_NoValuesWillBeRemoved()
        {
            //arange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 21;
            int secondItemToAdd = 22;
            int thirdItemToAdd = 23;
            int itemToRemove = 99;
            int expected = 3;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(secondItemToAdd);
            testList.Add(thirdItemToAdd);
            testList.Remove(itemToRemove);
            actual = testList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}
