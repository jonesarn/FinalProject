using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Badges.REPO;
using Badges.POCO;
namespace Badges
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