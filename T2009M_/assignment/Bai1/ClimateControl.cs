﻿using System;

namespace T2009M_.assignment.Bai1
{
    public class ClimateControl : Clothing
    {
        public override void Sales()
        {
            Console.WriteLine("All the places that bring in average sale: Climate Control Garments");

        }

        public override void Materials()
        {
            Console.WriteLine("Materials: Knit fabrics");
        }

        public override void CommonWear()
        {
            throw new System.NotImplementedException();
        }
    }
}