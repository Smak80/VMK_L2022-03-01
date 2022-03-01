using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMK_L2022_03_01
{
    public struct Struct1
    {
        public int A { get; set; }
        public static int ObjCount { get; private set; }
        public Struct1()
        {
            A = 3;
            ObjCount++;
        }
    }
    public class Class1
    {
        public int A { get; set; }
        public static int ObjCount { get; private set; }
        public Class1()
        {
            A = 3;
            ObjCount++;
        }

        public static int Method()
        {
            return ObjCount;
        }

        public void ObjMethod()
        {
            Method();
        }
    }
}
