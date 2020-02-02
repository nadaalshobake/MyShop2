﻿using System;

namespace MyShop.Core.Models
{
    internal class RangeAttribute : Attribute
    {
        private int v1;
        private int v2;

        public RangeAttribute(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}