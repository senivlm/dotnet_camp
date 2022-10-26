using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    internal class TestClass
    {
        public static int x = 2;
        private int y;

        public TestClass()
        {
            x = 1;
        }

        public TestClass(int y)
        {
            //this.x = x;
            this.y = y;
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }


        // якшо зміна створюється змінна всредині методу, але є десь
        // неініціалізована змінна, то використовується out
        // якшо вже існує десь то використовується ref
        public void Change(out int a, out int b)
        {
            a = 1;
            b = 1;

            Console.WriteLine($"a - {a} - b - {b}");
        }

        public void ParentalMethod()
        {
            Console.WriteLine("ParentalMethod");
        }

        public virtual void ParentMethodOrigin()
        {
            Console.WriteLine("origin");
        }

        public override string ToString()
        {
            return $"x - {X}, y - {Y}";
        }

    }
}
