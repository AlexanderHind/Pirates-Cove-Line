namespace Pirates_Cove_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrplan fahrplan = new Fahrplan();
            fahrplan.Name = "Test";
            Secret_Service s1 = new Secret_Service();
            BritBus br1 = new BritBus();
            br1.Name = "Britti";
            Station station = new Station();
            station.Name = "Dublin";
            station.Britbus = br1;
            station.Fahrgaeste();
            Console.WriteLine("Fahrgäste im Bus : "+br1.AnzGaeste());
            Station station1 = new Station();
            station1.Name = "Pirates Cove";
            station1.Britbus = br1;
            station1.Fahrgaeste();
            Console.WriteLine("Fahrgäste im Bus : " + br1.AnzGaeste());
            Station station3 = new Station();
            station3.Name = "London";
            station3.Britbus = br1;
            station3.Fahrgaeste();
            Console.WriteLine("Fahrgäste im Bus : " + br1.AnzGaeste());
            Station station4 = new Station();
            station4.Name = "Brüssel";
            station4.Britbus = br1;
            station4.Fahrgaeste();
            Console.WriteLine("Fahrgäste im Bus : " + br1.AnzGaeste());
            Station station5 = new Station();
            station5.Name = "Köln";
            station5.Britbus = br1;
            station5.Fahrgaeste();
            Console.WriteLine("Fahrgäste im Bus : " + br1.AnzGaeste());
            Station station6 = new Station();
            station6.Name = "Priates Cove GmbH";
            station6.Britbus = br1;
            station6.Fahrgaeste();
            Console.WriteLine("Fahrgäste im Bus : " + br1.AnzGaeste());
            Station station7 = new Station();
            station7.Name = "Berlin";
            station7.Britbus = br1;
            station7.Fahrgaeste();
            Console.WriteLine("Fahrgäste im Bus : " + br1.AnzGaeste());
            fahrplan.Stationen.Add(station);
            fahrplan.Stationen.Add(station1);
            fahrplan.Stationen.Add(station3);
            fahrplan.Stationen.Add(station4);
            fahrplan.Stationen.Add(station5);
            fahrplan.Stationen.Add(station6);
            fahrplan.Stationen.Add(station7);
          

        }
    }
}