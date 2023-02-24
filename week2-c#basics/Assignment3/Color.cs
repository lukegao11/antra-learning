using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public class Color
    {
        public int red{ get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int alpha { get; set; }
        public Color(int red, int green, int blue, int alpha) { 
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 225;
        }

        public int GetGrayscale() { return (red + blue + green)/3;}

    }
}
