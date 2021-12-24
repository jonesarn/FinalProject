namespace ChalengeTwo.UT{
    [TestClass]
    public class TestChallengeTwoMethods
    {
        [TestMethod]
        public void TestClaimActive()
        {
        //arrange
            CreateClaim testClaim = new CreateClaim();
            Bool result;
        //assert
            result = testClaim.CreateClaim();
        //act
            result.Assert(true);
        }
        

    }

}