using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern.ConcreteObjects.Japanese
{
    public class RunningSushi : Command
    {
        private  SushiMaster SushiMaster { get; set; }
        private string[] ToppingSelection { get; set; }
        public RunningSushi(SushiMaster sushiMaster, string[] toppingSelection)
        {
            this.SushiMaster = sushiMaster;
            this.ToppingSelection = toppingSelection; 
        }
        public void Execute()
        {
            while (true)
            {
                foreach (var topping in ToppingSelection)
                {
                    SushiMaster.MakeRice();
                    SushiMaster.AddTopping(topping);
                }
            }
            
        }
    }
}
