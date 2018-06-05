using System;
using System.Collections.Generic;
using System.Text;

namespace Elfly.DesignPattern.Proxy
{
    /// <summary>
    /// 模块特性，标记需要被动态代理的模块
    /// </summary>
    public class ModuleAttribute:Attribute
    {
        public string moduleName;

        public ModuleAttribute(string moduleName)
        {
            this.moduleName = moduleName;
        }
    }
}
