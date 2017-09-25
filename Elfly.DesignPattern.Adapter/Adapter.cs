using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Adapter
{
    public class Adapter:Target
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public override void SayHello()
        {
            _adaptee.Morning();
        }

        public override void SayGoodBye()
        {
            _adaptee.Evening();
        }
    }
}
