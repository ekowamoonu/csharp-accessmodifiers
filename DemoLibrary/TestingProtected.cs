using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    internal class TestingProtected:AccessDemo
    {

        public void TestMethod()
        {
            ProtectedDemo();
            PrivateProtectedDemo();

        }
    }
}
