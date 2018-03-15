using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Factory
{
    public class MicroSoft : GameConsole
    {
        public override string ShowProducts()
        {
            this.Name = "XBox 1 X";
            this.Type = 100;
            this.Amount = 4000;
            return base.ShowProducts();
        }
    }
}
