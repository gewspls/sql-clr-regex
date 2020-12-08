namespace SQL.CLR.RegEx.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit;
    using System.Data.SqlTypes;
    using SQL.CLR.RegEx.Functions;

    [TestClass]
    public class RegExFunctionReplaceTests
    {
        [TestMethod]
        public void MakesReplacementCorrectly_ReplaceHello_With_Goodbye()
        {
            // Arrange
            var pattern = "Hello";
            var expression = "WorldHello";
            var replacement = "Goodbye";

            // Act
            var result = RegExFunction.Replace(pattern, expression, replacement);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "WorldGoodbye");
            Assert.IsInstanceOfType(result, typeof(SqlString));
        }

        [TestMethod]
        public void ReturnsOriginalStringWhenMatchNotFound_HelloWorld()
        {
            // Arrange
            var pattern = "NotHello";
            var expression = "HelloWorld";
            var replacement = "Goodbye";

            // Act
            var result = RegExFunction.Replace(pattern, expression, replacement);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "HelloWorld");
            Assert.IsInstanceOfType(result, typeof(SqlString));
        }
    }
}
