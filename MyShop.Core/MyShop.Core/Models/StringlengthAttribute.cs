using System;

namespace MyShop.Core.Models
{
    internal class StringlengthAttribute : Attribute
    {
        private int v;

        public StringlengthAttribute(int v)
        {
            this.v = v;
        }
    }
}