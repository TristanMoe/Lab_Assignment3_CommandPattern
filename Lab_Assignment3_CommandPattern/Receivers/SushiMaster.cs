using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern
{
    public class SushiMaster
    {
        #region Constructor

        #endregion

        #region Properties
        private ToppingFactory ToppingFactory { get; set; } = new ToppingFactory();

        #endregion

        #region Methods
        public void MakeRice()
        {
            Console.WriteLine("Boiling rice");
            Console.WriteLine("Shaping rice ");
        }

        public void AddTopping(string toppingType)
        {
            var sushiPiece = ToppingFactory.CreateSushiPiece(toppingType); 
            Console.WriteLine($"Created {sushiPiece.Print()}");
        }
        #endregion
    }
}
