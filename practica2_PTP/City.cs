

namespace practica2_PTP
{
    class City
    {
        public string name;
        public List<PoliceStation> PoliceStations { get; private set; }
        public List<Taxi> Taxis { get; private set; }
        public City(string name)
        {
            this.name = name;
            PoliceStations = new List<PoliceStation>();
            Taxis = new List<Taxi>();
        }

        public string GetName()
        {
            return this.name;
        }

        public override string ToString()
        {
            return $"City  {GetName()}";
        }



        public void AddPoliceStation(PoliceStation station)
        {
            PoliceStations.Add(station);
        }
        public void RegisterLicense(Taxi car)
        {

            Taxis.Add(car);
            car.NewLicense();

        }
        public void WithdrawLicense(Taxi car)
        {
            Taxis.Remove(car);
            car.LoseLicense();
        }

    }
}

