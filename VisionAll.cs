using NyxVision.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyxVision
{
    public class VisionAll : Begin
    {
        [Test]
        public void ExecuteAll()
        {
            new LoginPageTest();
            new Test();
        }
    }
}
