using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class BusinessWagon : PersonalWagon {
        Person Steward { get; set; }

        public BusinessWagon(Person steward, int numberOfChairs) : base(numberOfChairs) {
            Steward = steward;
        }

        public override string ToString() {
            return $"Business wagon [number of sits = {NumberOfChairs}, steward = {Steward.ToString()}]";
        }
    }
}
