//Еще не доделано
using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]                      x
        [InlineData(1.1, 0.009, 2.8, 20.109)] //tst1
        [InlineData(4.1, 2.7, 3.6, 13.568)] //tst2
        public void TestEquat(double a, double b, double x, double exp)
        {
            Assert.Equal(Program.Equat(a, b, x), exp, 3); 
        }
        
        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(1.1, 0.09, 1.2, 2.2, 0.2);
            Assert.Equal(res, new double[0]);
        }
        
        
        
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
    }
}
