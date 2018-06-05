using System;
using System.Collections.Generic;
using System.Text;

namespace Elfly.DesignPattern.Proxy
{
    /// <summary>
    /// 方法特性，用于标记需要被动态代理的方法
    /// </summary>
    public class MethodAttribute : Attribute
    {
        public string name;
        public MethodAttribute(string name )
        {
            this.name = name; 
        }
    }
}
