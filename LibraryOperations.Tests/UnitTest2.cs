using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace LibraryOperations.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void FirstMethod_Should_Return_Right_Results()
        {
            Mock<MySecondClass> secondClass = new Mock<MySecondClass>();
            secondClass.Setup(x => x.SecondMethod(It.IsAny<string>()));  //.Returns("textabc"); 
            //without Returns() it returns default value (in this case default(string))

            var firstClass = new MyFirstClass(secondClass.Object);
            var actual = firstClass.FirstMethod("text");
            var expected = "def"; //textabcdef
            Assert.AreEqual(actual, expected);
            secondClass.Verify(x=>x.AnotherMethod(It.IsAny<string>())); //check if function was invoked (for functions which return void)
        }
    }
}
