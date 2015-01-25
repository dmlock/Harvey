using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Harvey.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProgramCtorThrowsArgumentNullExceptionTest()
        {
            var logger = new Mock<ILogger>();
            var p = new Program(logger.Object, null);
            Assert.IsNull(p);
        }
        [TestMethod]
        public void ProgramRunWithNoArgsLogsSomethingTest()
        {
            var logger = new Mock<ILogger>();
            var config = new Mock<IProgramConfig>();
            var args = GetProgramEmptyArgs();
            var p = new Program(logger.Object, config.Object);
            p.Start();
            logger.Verify(c => c.Log(It.IsAny<string>(), It.IsAny<string[]>()), Times.Once);
        }
        private string[] GetProgramEmptyArgs()
        {
            var returnValue = new string[0];
            return (returnValue);
        }
    }
}
