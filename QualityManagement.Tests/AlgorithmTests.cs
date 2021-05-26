using System;
using System.Collections.Generic;
using System.Linq;
using QualityManagement.Shared;
using Xunit;
using static QualityManagement.Shared.PieceOfText;

namespace QualityManagement.Tests
{
    public class AlgorithmTest
    {
        [Fact]
        public void Test1()
        {
            var data = new BasicEnvironment();
            var result = SearchForFragments(data.TestData1.TestString);
            Assert.Equal(data.TestData1.Results.ToSimpleText(), result.ToSimpleText());
        }

        [Fact]
        public void Test2()
        {
            var data = new BasicEnvironment();
            var result = SearchForFragments(data.TestData2.TestString);
            Assert.Equal(data.TestData2.Results.ToSimpleText(), result.ToSimpleText());
        }

        [Fact]
        public void Test3()
        {
            var data = new BasicEnvironment();
            var result = SearchForFragments(data.TestData3.TestString);
            Assert.Equal(data.TestData3.Results.ToSimpleText(), result.ToSimpleText());
        }
    }
}
