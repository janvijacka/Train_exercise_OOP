using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class Hopper : Wagon {
        public double LoadingCapacity { get; set; }

        public Hopper(double tonnage) {
            LoadingCapacity = tonnage;
        }
        public override string ToString() {
            return $"Hopper [tonnage = {LoadingCapacity}]";
        }
    }
}
