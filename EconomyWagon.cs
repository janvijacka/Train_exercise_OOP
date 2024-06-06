using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class EconomyWagon : PersonalWagon {
        public EconomyWagon(int numberOfChairs) : base(numberOfChairs) { }

        public override string ToString() {
            return $"Economy wagon [number of sits = {NumberOfChairs}]";
        }
    }
}
