using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class Locomotive {
        public Person driver = new Person("", "");
        public Engine engine = new Engine("");
        public Person Driver { get; set; }
        public Engine Engine { get; set; }

        public Locomotive() { }
        public Locomotive(Person Driver, Engine Engine) {
            this.Driver = Driver;
            this.Engine = Engine;
        }
        
        public override string ToString() {
            return $"Driver {Driver.ToString()}\nEngine {Engine.ToString()}";
        }
    }
}
