using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonAOPDemo
{
    public class Calculator
    {
        #region Methods

        public int Add(int x, int y)
        {
            Track("Add", "Start");
            TrackValues("x", x);
            TrackValues("y", y);

            int rv = x + y;

            TrackValues("Return Value", rv);
            Track("Add", "End");

            return rv;
        }

        public double Divide(int x, int y)
        {
            Track("Divide", "Start");
            TrackValues("x", x);
            TrackValues("y", y);
            if(y<=0)
            {
                throw new ArgumentOutOfRangeException("y", "y cannot be less then or equal to 0");
            }
            int rv = x / y;

            TrackValues("Return Value", rv);
            Track("Divide", "End");

            return rv;
        }

        public int Multiply(int x, int y)
        {
            Track("Multiply", "Start");
            TrackValues("x", x);
            TrackValues("y", y);

            int rv = x * y;

            TrackValues("Return Value", rv);
            Track("Multiply", "End");

            return rv;
        }

        public int Subtract(int x, int y)
        {
            Track("Subtract", "Start");
            TrackValues("x", x);
            TrackValues("y", y);

            int rv = x - y;

            TrackValues("Return Value", rv);
            Track("Subtract", "End");

            return rv;
        }

        private void Track(string method, string operation)
        {
            Console.WriteLine("{0} {1}", operation, method);
        }

        private void TrackValues(string variable, object value)
        {
            Console.WriteLine("{0}={1}", variable, value);
        }

        #endregion Methods
    }
}