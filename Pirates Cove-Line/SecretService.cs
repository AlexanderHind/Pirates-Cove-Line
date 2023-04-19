using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Cove_Line
{
    internal class Secret_Service
    {
       private List<BritBus> britBuses = new List<BritBus>();
        public List<Fahrgast> Verbrechers { get; set; }

        public void AddBus(BritBus b)
        {
            britBuses.Add(b);
        }
        public BritBus GetBus(BritBus m) 
        {
            int i;
            for (i = 0; i < britBuses.Count;)
            {
                if (britBuses[i].Name == m.Name)
                {
                    break;
                }
                
            }
                    return britBuses[i];
        }
        public void AddGaeste(Fahrgast g)
        {
            Verbrechers.Add(g);
        }
        public Fahrgast GetVerbrechers(string n)
        {
            int i;
            for ( i = 0; i < Verbrechers.Count; i++)
            {
                if (Verbrechers.Equals(n))
                {
                    break;
                }
            }
            return Verbrechers[i];
        }

    }
}
