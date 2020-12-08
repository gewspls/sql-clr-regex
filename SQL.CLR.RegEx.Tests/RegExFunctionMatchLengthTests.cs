namespace SQL.CLR.RegEx.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit;
    using System.Data.SqlTypes;
    using SQL.CLR.RegEx.Functions;

    [TestClass]
    public class RegExFunctionMatchLengthTests
    {
        [TestMethod]
        public void ReturnsCorrectLength_Match_Hello_In_WorldHello()
        {
            // Arrange
            var pattern = "Hello";
            var expression = "WorldHello";

            // Act
            var result = RegExFunction.MatchLength(pattern, expression);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 5);
            Assert.IsInstanceOfType(result, typeof(SqlInt32));
        }

        [TestMethod]
        public void ReturnsZeroWhenMatchNotFound_DoNotMatch_NotHello_In_HelloWorld()
        {
            // Arrange
            var pattern = "NotHello";
            var expression = "HelloWorld";

            // Act
            var result = RegExFunction.MatchLength(pattern, expression);

            // Assert
            Assert.AreEqual(result, 0) ;
            Assert.IsInstanceOfType(result, typeof(SqlInt32));
        }
    }
}
