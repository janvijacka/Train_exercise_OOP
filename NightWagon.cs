using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class NightWagon : PersonalWagon {
        public Bed Beds { get; set; }
        public int NumberOfBeds { get; set; }
        List<Bed> beds = new List<Bed>();

        public NightWagon(int numberOfChairs,int numberOfBeds) : base(numberOfChairs) {
            NumberOfBeds = numberOfBeds;
            for (int i = 0; i < numberOfBeds; i++) {
                beds.Add(new Bed());
                beds[i].Number = i + 1;
            }
        }
        public override string ToString() {
            return $"Night wagon [number of sits = {NumberOfChairs}, number of beds = {NumberOfBeds}]";
        }
    }
}
