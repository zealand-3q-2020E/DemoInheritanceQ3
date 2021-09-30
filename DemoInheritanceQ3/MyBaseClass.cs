using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInheritanceQ3
{
    /// <summary>
    /// this is a comment
    /// </summary>
    public abstract class MyBaseClass
    {
        /// <summary>
        /// more summeries
        /// </summary>
        private string MyBaseProperty { get; set; }
        public MyBaseClass(string prop)
        {
            this.MyBaseProperty = prop;
        }
        /// <summary>
        /// this is my baseclass
        /// </summary>
        public MyBaseClass()
        {

        }


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
