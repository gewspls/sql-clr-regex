namespace SQL.CLR.RegEx.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit;
    using System.Data.SqlTypes;
    using SQL.CLR.RegEx.Functions;

    [TestClass]
    public class RegExFunctionMatchTests
    {
        [TestMethod]
        public void ReturnsCorrectMatch_Match_Hello_In_HelloWorld()
        {
            // Arrange
            var pattern = "Hello";
            var expression = "HelloWorld";

            // Act
            var result = RegExFunction.Match(pattern, expression);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "Hello");
            Assert.IsInstanceOfType(result, typeof(SqlString));
        }

        [TestMethod]
        public void ReturnsNullWhenMatchNotFound_DoNotMatch_NotHello_In_HelloWorld()
        {
            // Arrange
            var pattern = "NotHello";
            var expression = "HelloWorld";

            // Act
            var result = RegExFunction.Match(pattern, expression);

            // Assert
            Assert.AreEqual(result, SqlString.Null) ;
            Assert.IsInstanceOfType(result, typeof(SqlString));
        }
    }
}
