using System;
using UnitTestSample;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMockMethod01()
        {
            var mock = new ClassWithStaticMock();
            mock.Method01(); // it works. 
            Assert.True(true);
        }

        [Fact]
        public void TestMockMethod02()
        {
            var obj = new ClassWithStatic();
            obj.SomethingToDo = () => { }; // do nothing
            obj.Method02();
            Assert.True(true);
        }

        private class ClassWithStaticMock : ClassWithStatic
        {
            internal override void DoSomething()
            {
                // do nothing. 
            }
        }
    }
}
