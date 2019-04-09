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
        public SushiPiece CreateSushiPiece(string type)
        {
            switch (type.ToLower())
            {
                case "shrimp": return new Shrimp();
                case "salmon": return new Salmon();
                default: throw new Exception("Unknown Sushi piece");
            }
           
        }
    }
}
