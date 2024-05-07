using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample002
{
    public class BaseClass
    {
        public virtual void Execute()
        {
            Console.WriteLine("BaseClass Execute Method");
        }
        public virtual void Begin() 
        {
            Console.WriteLine("BaseClass Begin Method");
        }
        public class Class1 : BaseClass
        {
            public override void Execute()
            {
                Console.WriteLine("Class1 Execute Method");
            }
        }
        public class Class2 : Class1
        {
            public override sealed void Execute()
            {
                Console.WriteLine("Class2 Execute Method");
            }
            public override void Begin()
            {
                Console.WriteLine("Class2 Begin Method");
            }
        }
    }
}
