using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Adapter
{
    /// <summary>
    /// 适配器，通过适配器实现调用
    /// </summary>
    public class Adapter : Target
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            if (_adaptee == null)
                _adaptee = new Adaptee();
        }

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
