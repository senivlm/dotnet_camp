using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    internal class InheritenceTest : TestClass
    {
        private readonly int x;
        private readonly string z;

        public InheritenceTest(int x, int y, string z) : base(y)
        { 
            this.x = x;
            this.z = z;
        }

        public void ChildMethod()
        {
            Console.WriteLine("ChildMethod");
        }

        public void ParentMethodOrigin()
        {
            Console.WriteLine("child origin");
        }

        public override string ToString()
        {
            return base.ToString() + $" z - {z}";
        }
    }
}
