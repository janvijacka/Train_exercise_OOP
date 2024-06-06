using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class Wagon {
        public void ConnectToTrain(Train train) {
            train.ConnectWagon(this);
        }
        public void DisconnectFromTrain(Train train) {
            if (train.wagons.Contains(this)) {
                train.DisconnectWagon(this);
            }
            else {
                Console.WriteLine("Tento vagón není připojen k zmíněnému vlaku.");
            }
        }
    }
}
