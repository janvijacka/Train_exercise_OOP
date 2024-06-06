namespace TrainVijacka;

class Program {
    static void Main(string[] args) {
        Person driver = new Person("Sheldon", "Cooper");
        Engine eParni = new Engine("parní");
        Engine eDiesel = new Engine("dieselová");
        Locomotive locomotive1 = new Locomotive(driver, eParni);       
        Train train1 = new Train(locomotive1);
        EconomyWagon ew1 = new EconomyWagon(30);
        Person steward = new Person("Jitka", "Dobrá");
        BusinessWagon bw1 = new BusinessWagon(steward, 20);
        NightWagon nw1 = new NightWagon(10, 15);
        Hopper h1 = new Hopper(50.5);


        ew1.ConnectToTrain(train1);
        h1.ConnectToTrain(train1);
        bw1.ConnectToTrain(train1);
        train1.ReserveChair(3, 1);
        train1.listReservedChairs();
        ew1.ConnectToTrain(train1);
        ew1.ConnectToTrain(train1);
        ew1.ConnectToTrain(train1);
        Train train2 = new Train(locomotive1);
        ew1.DisconnectFromTrain(train2);
    }
}