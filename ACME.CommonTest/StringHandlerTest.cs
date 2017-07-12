using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.Common;

namespace ACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestWithoutSpaces()
        {

            //arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";


            //act
            var actual = source.InsertSpaces();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpaces()
        {

            //arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";


            //act
            var actual = StringHandler.InsertSpaces(source);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
