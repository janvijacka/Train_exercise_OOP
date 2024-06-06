using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainVijacka {
    internal class Train {
        Locomotive locomotive = new Locomotive();
        public List<Wagon> wagons = new List<Wagon>();
        public static int countOfWagons = 0;

        public Train() { }
        public Train(Locomotive locomotive) {
            this.locomotive = locomotive;
        }
        public Train(Locomotive locomotive, List<Wagon> wagons) {
            this.locomotive = locomotive;
            this.wagons = wagons;
        }
        public void ConnectWagon(Wagon wagon) {
            if (locomotive.Engine.Type == "parní" && countOfWagons >= 5) {
                Console.WriteLine("Nelze připojit více než 5 vagonu.");
            }
            else {
                wagons.Add(wagon);
                countOfWagons++;
            }
        }
        public void DisconnectWagon(Wagon wagon) {
            wagons.Remove(wagon);
            countOfWagons--;
        }
        public void ReserveChair(int wagonNumber,  int chairNumber) {
            //((PersonalWagon)wagons[wagonNumber]).Sits[chairNumber - 1].Reserved = true;
            if (wagonNumber <= countOfWagons && !(wagons[wagonNumber -1] is Hopper) && chairNumber <= ((PersonalWagon)wagons[wagonNumber -1]).NumberOfChairs) {
                ((PersonalWagon)wagons[wagonNumber - 1]).Sits[chairNumber - 1].Reserved = true;
            }
        }
        public void listReservedChairs() {
            string text = "Rezervovaná sedadla:\n";
            foreach (Wagon wagon in wagons) {
                if (!(wagon is Hopper)) {
                    text += wagon.ToString() + "\n";
                    foreach (Chair sit in ((PersonalWagon)wagon).Sits) {
                        if (sit.Reserved) {
                            text += sit.ToString() + "\n";
                        }
                    }
                }
            }
            Console.WriteLine(text);
        }
        public override string ToString() {
            string text = $"lokomotiva:\n{locomotive.ToString()}\nvagóny:\n";
            foreach (Wagon wagon in wagons) {
                text += wagon.ToString() + "\n";
            }
            return text;
        }
    }
}
