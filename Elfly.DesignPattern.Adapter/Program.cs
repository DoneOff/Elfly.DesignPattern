using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            Target target = new Adapter(adaptee);

            //调用Say Hello
            target.SayHello();

            //调用Say GoodBye
            target.SayGoodBye();

            Console.ReadLine();
        }
    }
}
