using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    class Ver : Attribute
    {
        public readonly int major;
        public readonly int minor;

        public Ver(int major,int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public override string ToString()
        {
            return string.Format("Ver: {0},{1}",this.major,this.minor);
        }
    }
}
