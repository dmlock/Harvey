using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Harvey.Tests
{
    [TestClass]
    public class ProgramConfigTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProgramConfigCtorThrowsArgumentNullExceptionTest()
        {
            var p = new ProgramConfig(null);
            Assert.IsNull(p);
        }
        [TestMethod]
        public void ProgramConfigCtorSetsUpUrlParameterTest()
        {
            var p = new ProgramConfig(GetProgramArgsWithUrl());
            Assert.AreEqual("Url", p.Url);
        }
        private string[] GetProgramArgsWithUrl()
        {
            var returnValue = new string[1];
            returnValue[0] = "Url";
            return (returnValue);
        }
    }
}
