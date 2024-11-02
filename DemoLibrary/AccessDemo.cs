using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {
        //Access everywhere
        public void PublicDemo() {
            Console.WriteLine("Hello from public demo");
        }

        //Access only within class
        private void PrivateDemo() { }

        //Access only with assembly
        internal void InternalDemo() { }

        //Access only within class and derived classes. Not objects
        protected void ProtectedDemo() { }

        //Private outside assembly, protected within assembly
        private protected void PrivateProtectedDemo() { }

        //Protected outside assembly, internal within assmebly
        protected internal void ProtectedInternalDemo() { }
    }
}
