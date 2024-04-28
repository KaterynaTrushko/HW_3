using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeccardPoint
    {
    public class Point
        {
        public Point(double x, double y) 
            {
            X = x;
            Y = y;
            }
        decimal x;
        decimal y;
        public double X
            {
            get; set;
/*            get
                {
                if (this.x == null) { throw new ArgumentNullException(paramName: nameof(x), message: "X cannot be null"); }
                else { return (double)x; }
                }
            set
                {
                if (value != null) X = value;
                else throw new ArgumentNullException(paramName: nameof(x), message: "X cannot be null");
                }*/
            }
        public double Y 
            {
            get;set;
/*            get
                {
                if (this.y == null) { throw new ArgumentNullException(paramName: nameof(y), message: "Y cannot be null"); }
                else { return (double)x; }
                }
            set
                {
                if (value != null) Y = value;
                else throw new ArgumentNullException(paramName: nameof(y), message: "X cannot be null");
                }*/

            }
        public void Print()
            {
            try
                {
                Console.WriteLine($"Point with x:{this.X} and y:{this.Y} coordinates");
                }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
            }
        }

    }
