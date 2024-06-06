using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class Engine {
        string type = string.Empty;
        public string Type { get; set; }

        public Engine(string type) {
            Type = type;
        }

        public override string ToString() {
            return $"[type = {Type}]";
        }
    }
}
