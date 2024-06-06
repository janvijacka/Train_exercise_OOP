using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class Door {
        public double Height { get; set; }
        public double Width { get; set; }

        public Door(double height, double width) {
            Height = height;
            Width = width;
        }
    }
}
