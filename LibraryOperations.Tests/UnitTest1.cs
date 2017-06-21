using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LibraryOperations.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateMemberShipCost_Should_Return_Right_Results()
        {
            Mock<IMemberManager> myMock = new Mock<IMemberManager>();
            myMock.Setup(x => x.GetMember(It.IsAny<int>())).Returns(new Member { MemberID = 1, MaximumBookCanBorrow = 10 });

            var libraryCore = new LibraryCore(myMock.Object);

            var actual = libraryCore.CalculateMemberShipCost(1);
            var expected = 105;
            Assert.AreEqual(actual, expected);
        }


        private void CalculateMemberShipCostTest(int source,double expected,string message)
        {
            var manager = new MemberManager();
            var libraryCore = new LibraryCore(manager);
            var actual = libraryCore.CalculateMemberShipCost(source);
            Assert.AreEqual(actual, expected,message);
        }

        [TestMethod]
        public void CalculateMemberShipCost_Without_Mock_Should_Return_Right_Results()
        {
            CalculateMemberShipCostTest(1, 122.5, "expected 122.5");

            CalculateMemberShipCostTest(2, 127, "expected 127");
        }
    }
}
