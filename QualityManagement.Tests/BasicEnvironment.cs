using System;
using System.Collections.Generic;
using System.Text;


namespace QualityManagement.Tests
{
    class BasicEnvironment
    {
        public TestData TestData1 = new TestData
        {
            TestString = "a a a b b b a a a b b b a a a",
            Results = new Dictionary<string, int> 
            {
                {"a a a", 3},
                {"a a a b", 2},
                {"a a a b b", 2},
                {"a a a b b b", 2},
                {"a a a b b b a", 2},
                {"a a a b b b a a", 2},
                {"a a a b b b a a a", 2},
                {"a a b", 2},
                {"a a b b", 2},
                {"a a b b b", 2},
                {"a a b b b a", 2},
                {"a a b b b a a", 2},
                {"a a b b b a a a", 2},
                {"a b b", 2},
                {"a b b b", 2},
                {"a b b b a", 2},
                {"a b b b a a", 2},
                {"a b b b a a a", 2},
                {"b b b", 2},
                {"b b b a", 2},
                {"b b b a a", 2},
                {"b b b a a a", 2},
                {"b b a", 2},
                {"b b a a", 2},
                {"b b a a a", 2},
                {"b a a", 2},
                {"b a a a", 2}
            }
        };

        public TestData TestData2 = new TestData
        {
            TestString = "quality is, reality quality! is reality\nreality. is quality",
            Results = new Dictionary<string, int>
            {
                {"quality is reality", 2}
            }
        };

        public TestData TestData3 = new TestData
        {
            TestString = "Information security means protecting information and information systems from unauthorized access, use, disclosure, disruption, modification, perusal, inspection, recording or destruction.",
            Results = new Dictionary<string, int>
            {
                
            }
        };
    }
    internal class TestData
    {
        public string TestString;
        public IDictionary<string, int> Results;
    }
}
