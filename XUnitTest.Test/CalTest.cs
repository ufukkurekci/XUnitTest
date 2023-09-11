using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.APP;
using Xunit;

namespace XUnitTest.Test
{
    public class CalTest
    {
        [Fact]
        public void AddTest()
        {
            int a = 5;
            int b = 6;
            var cal = new Calculator();

            var total = cal.Sum(a, b);

            Assert.Equal(11, total);
        }
    }
}
