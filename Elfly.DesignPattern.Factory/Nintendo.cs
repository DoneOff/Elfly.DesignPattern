using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Factory
{
    public class Nintendo : GameConsole
    {
        public override string ShowProducts()
        {
            this.Name = "NintendoSwitch";
            this.Type = 2001;
            this.Amount = 3000;
            return base.ShowProducts();
        }
    }
}
