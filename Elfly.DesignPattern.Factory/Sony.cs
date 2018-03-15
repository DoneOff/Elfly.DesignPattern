using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Factory
{
    public class Sony : GameConsole
    {
        public override string ShowProducts()
        {
            this.Name = "PS4 PRO";
            this.Type = 1;
            this.Amount = 10000;
            return base.ShowProducts();
        }
    }
}
