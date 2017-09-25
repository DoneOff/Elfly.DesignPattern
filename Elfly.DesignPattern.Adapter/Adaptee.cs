using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Adapter
{
    /// <summary>
    /// 需要适配的类，此类型业务场景一般是后期增加的。
    /// </summary>
    public class Adaptee
    {
        public void Morning()
        {
            Console.WriteLine("Adaptee:Say Morning!");

        }

        public void Evening()
        {
            Console.WriteLine("Adaptee:Say Evening!");
        }
    }
}
