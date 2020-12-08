namespace SQL.CLR.RegEx.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit;
    using System.Data.SqlTypes;
    using SQL.CLR.RegEx.Functions;

    [TestClass]
    public class RegExFunctionMatchPositionTests
    {
        [TestMethod]
        public void ReturnsCorrectPosition_Match_Hello_In_WorldHello()
        {
            // Arrange
            var pattern = "Hello";
            var expression = "WorldHello";

            // Act
            var result = RegExFunction.MatchPosition(pattern, expression);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 5);
            Assert.IsInstanceOfType(result, typeof(SqlInt32));
        }

        [TestMethod]
        public void ReturnsMinusOneWhenMatchNotFound_DoNotMatch_NotHello_In_HelloWorld()
        {
            // Arrange
            var pattern = "NotHello";
            var expression = "HelloWorld";

            // Act
            var result = RegExFunction.MatchPosition(pattern, expression);

            // Assert
            Assert.AreEqual(result, -1) ;
            Assert.IsInstanceOfType(result, typeof(SqlInt32));
        }
    }
}
