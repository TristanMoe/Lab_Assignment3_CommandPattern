using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern
{
    public class ToppingFactory
    {
        public ISushiPiece CreateSushiPiece(string type)
        {
            switch (type.ToLower())
            {
                case "shrimp": return new Shrimp();
                case "salmon": return new Salmon();
                case "octopus": return new Octupus();
                default: throw new Exception("Unknown Sushi piece");
            }
           
        }
    }
}
