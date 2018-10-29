using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosKernel2
{
    class Calc
    {
        private float c;
        public Calc()
        {
            c = 0;
        }

        public float Topla(float a, float b)
        {
            c = a + b;
            return c;
        }

        public float Cikar(float a, float b)
        {
            c = a - b;
            return c;
        }

        public float Carp(float a, float b)
        {
            c = a * b;
            return c;
        }

        public float Bol(float a, float b)
        {
            c = a / b;
            return c;
        }
    }
}
