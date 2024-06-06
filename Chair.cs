using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class Chair {
        public bool reserved = false;
        public bool NearWindow { get; set; }
        public int Number { get; set; }
        public bool Reserved { get; set; }

        public Chair(int number, bool nearWindow) {
            Number = number;
            NearWindow = nearWindow;
        }
        public override string ToString() {
            return $"číslo sedadla {Number + 1}, reserved {Reserved}";
        }
    }
}
