﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void TestReadMethod(){
            //arrange
                
            //act

            //assert
            
        }
    }
}
