using System;
using System.Collections.Generic;
using System.Text;



namespace DemoInheritanceQ3
{
    public class MySpecializedClass : MyBaseClass, IMyInterface
    {
        public override string MyAbstractMethod()
        {
            return "in MyAbstractMethod";
        }

        public override string MyBaseClassMethod()
        {
            //return base.MyBaseClassMethod();

            return " In the specialized class override and Mybassclassmethod";
        }

        public string MyInterfaceMethod()
        {
            return "in specialized class in MyInterfaceMethod()";
        }

        public string MySpecializedMethod()
        {
            return "MySpecializedMethod";
        }

        public override string ToString()
        {
            return base.ToString() + MyInterfaceMethod();
        }
    }
}
