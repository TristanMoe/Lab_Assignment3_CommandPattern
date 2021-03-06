﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern
{
    public interface ISushiPiece
    {
        string Print(); 
    }

    public class Salmon : ISushiPiece
    {
        public string Print()
        {
            return"a ball of rice with salmon on top";
        }
    }

    public class Shrimp : ISushiPiece
    {
        public string Print()
        {
            return "a ball of rice with shrimp on top";
        }
    }

    public class Octupus : ISushiPiece
    {
        public string Print()
        {
            return "a niece piece of fried octupus with rice on the side";
        }
        
    }

}
