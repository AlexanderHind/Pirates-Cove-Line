namespace Pirates_Cove_Line
{
    internal class Station
    {
        public string Name { get; set; }
        private Random random = new Random();
        //private Stack<Fahrgast> fahrgasts = new Stack<Fahrgast>();
        public BritBus Britbus { get; set; }

        public void Fahrgaeste()
        {
            Console.WriteLine(Name);
            // Einsteigen
            int p = random.Next(1, 8);
            for (int i = 0; i < p; i++)
            {
                Fahrgast f = new Fahrgast(this);
                //fahrgasts.Push(f);
                Britbus.Einsteigen(f);
            }
            Console.WriteLine(p + " Fahrgäste eingestiegen!");

            //Aussteigen
            int r = random.Next(1, 8);
            if (Britbus.AnzGaeste() > r && Britbus.Name == "Brittisch")
            {
                Britbus.BritischAussteigen(r);
                Console.WriteLine(r + " Fahrgäste ausgestiegen");
            }
            else if (Britbus.AnzGaeste() > r)
            {
                for (int i = r; i >= 0; i--)
                {
                    Britbus.Aussteigen();
                }
                Console.WriteLine(r + " Fahrgäste ausgestiegen");
            }

        }
    }
}
