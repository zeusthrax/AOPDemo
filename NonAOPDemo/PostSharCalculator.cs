using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PostSharp.Extensibility;
using PostSharp.Patterns.Contracts;
using PostSharp.Patterns.Diagnostics;

namespace NonAOPDemo
{
    [Log(AttributeTargetMemberAttributes = MulticastAttributes.Private | MulticastAttributes.Protected | MulticastAttributes.Internal | MulticastAttributes.Public)]
    public class PostSharpCalculator
    {
        #region Methods

        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Divide(int x, [StrictlyGreaterThan(0)] int y)
        {
            return x / y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        #endregion Methods
    }
}