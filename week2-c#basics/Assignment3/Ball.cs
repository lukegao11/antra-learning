using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public class Ball
    {
        private Color Color { get; set; }
        private int Size { get; set; }
        private int ThrowCounter { get; set; }

        public Ball(Color color, int Size, int ThrowCounter = 0) { 
            this.Color = color; 
            this.Size = Size;
            this.ThrowCounter = ThrowCounter;
        }

        public void Pop() {
            this.Size = 0;
        }
        public void Throw() {
            if (this.Size > 0) { 
                this.ThrowCounter++;
            }
        }
        public int GetThrowCount() { 
            return this.ThrowCounter;
        }

    }

}
