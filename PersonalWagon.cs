using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TrainVijacka {
    abstract class PersonalWagon : Wagon {
        List<Door> doors;
        List<Chair> sits = new List<Chair>();
        int numberOfChairs;
        public int NumberOfChairs { get; set; }
        public List<Chair> Sits { get; set; }

        public PersonalWagon(int numbeOfChairs) {
            NumberOfChairs = numbeOfChairs;
            Sits = new List<Chair>();
            for (int i = 0; i < numbeOfChairs; i++) {
                Sits.Add(new Chair(i ,false));
            }
        }
        public void ListChairs() {
            string text = string.Empty;
            foreach (Chair chair in Sits) {
                text += chair.ToString() + "\n";
            }
            Console.WriteLine(text);
        }
    }
}
