using Xunit;

namespace UiTest
{
    public class SampleTest 
    {
        [Fact]
        public void Just_For_Run_Sample_Test()
        {
            // Arrange
            var myvar = "test";

            //Act
            bool result= (myvar == "test");

            //Assert 
            Assert.True(result );  
        }
    }
}