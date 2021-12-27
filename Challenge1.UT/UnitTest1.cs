using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Challenge1.POCO;
using Challenge1.REPO;

namespace Challenge1.UT
{
    [TestClass]
    public class TestChallengeMethods
    {
        [TestMethod]
        public void TestCreateItemMethod()
        {
            //See if create item returns true
            //arrange
                CreateItem CreateTest = new CreateItem();
                Boolean result;
            //act
                result = CreateTest.CreateItem();
            //assert
                Assert.AreEqual(true,result);
        }
        //See if all items are read in the dictionary
        public void TestItemByMealNumber(){
            //arrange
                GetItemsByMealNumber CreateItemMealNumber = new GetItemsByMealNumber();
            //act
                result_MealNumber = CreateItemMealNumber.GetItemsByMealNumber(int mealNumber);

            //assert
                Assert.AreEqual(meal.Key,mealNumber);
        }
       public void TestDelete(){
           //arrange
           DeleteItem ItemDeleted = new DeleteItem();
           Boolean result_Delete;

           //act
           result_Delete = ItemDeleted.DeleteItem();

           //assert
           Assert.AreEqual(true,result_Delete)
           
       } 
    }
}
