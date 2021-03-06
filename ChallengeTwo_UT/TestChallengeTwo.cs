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
        [TestClass]
        public void IsValidActive()
        {
            //arrange
            IsValid testIsValid = new testIsValid();
            Boolean result_isValid;
            //assert
            result_isValid = testIsValid.IsValid();

            //act
            result.Assert(true,result_isValid);
            
        }
        [TestMethod]
        public void isClaimDeleted()
        {
            //arrange
            DeleteClaim testDeleteClaim = new testDeleteClaim();
            Boolean result_delete;

            //assert
            result_delete = testDeleteClaim.DeleteClaim(ClaimPoco claim);

            //act
            result_delete.Assert(true,result_delete);
        }
    }

}