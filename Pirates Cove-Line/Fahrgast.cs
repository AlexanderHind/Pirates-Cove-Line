namespace Pirates_Cove_Line
{
    internal class Fahrgast
    {
        public string VName { get; set; }
        //public string NName { get; set; }
        public Station StationsName { get; set; }
        private string[] vNamen = new string[] {"Marlene","Rachel","Lana","Emmy","Andreas","Joana","Neven","Ike","Tammo","Irem","Pelin","Anthony","Asya","Abby","Tia","Defne","Janosch","Feline","Rosalie","Levin","Nisa","Mirko","Marleen","Bernd","Juri","Miko","Yasmina","Götz","Chiara","Erik"};
        private Random random = new Random();
        public string Vnamensgenerator()
        {
           int test = random.Next(0,30);
            return vNamen[test];
        }
        public Fahrgast(Station s)
        {
            VName= Vnamensgenerator();
            StationsName = s;
        }
    }
}
