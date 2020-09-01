using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInheritanceQ3
{
    public abstract class MyBaseClass
    {

        public abstract string  MyAbstractMethod();

        public virtual string MyBaseClassMethod()
        {
            return "In class MyBaseClassMethod";
        }

        public override string ToString()
        {
            return MyBaseClassMethod();
        }
    }
}
