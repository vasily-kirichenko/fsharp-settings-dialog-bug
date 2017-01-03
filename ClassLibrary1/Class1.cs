using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [AttributeUsage]
    public class MyAttrib : Attribute
    { }

    [MyAttrib]
    public class Class1
    {
    }
}
