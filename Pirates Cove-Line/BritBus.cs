using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Cove_Line
{
    internal class BritBus
    {
        public String Name { get; set; }
        private Queue<Fahrgast> fahrgastsq = new Queue<Fahrgast>();
        private Stack<Fahrgast> fahrgasts = new Stack<Fahrgast>();
        public Stack<Station> Fahrplan { get; set; }
        private Secret_Service secret;
        

        public void Fahrt()
        {
            Fahrplan.Pop().Fahrgaeste();
        }
        public void Einsteigen(Fahrgast f)
        {
            if (fahrgasts.Count < 30)
            {
                secret.AddGaeste(f);
                fahrgasts.Push(f);
                fahrgastsq.Enqueue(f);
            }
            else
            {
                Console.WriteLine("Bus voll!");
            }
        }

        public void Listendreher()
        {
            IEnumerable<Fahrgast> test = fahrgastsq.Reverse().ToList();
            fahrgastsq.Clear();
            foreach (Fahrgast item in test)
            {
                fahrgastsq.Enqueue(item);
            }
            
        }
        public void BritischAussteigen(int r)
        {
            Listendreher();
            for (int i = 0; i < r; i++)
            {
            fahrgasts.Pop();
            fahrgastsq.Dequeue();
            }
            Listendreher();
        }
        
        public void Aussteigen()
        {
            fahrgasts.Pop();
            fahrgastsq.Dequeue();
        }

        public int AnzGaeste()
        {
            return fahrgasts.Count;
        }

        public void GetFahrgaeste()
        {
            foreach (Fahrgast item in fahrgasts)
            {
                Console.WriteLine(item.VName);
            }
        }
        public Fahrgast GetFahrgast(string f)
        {
            List<Fahrgast> testi = new List<Fahrgast>();
            testi.AddRange(fahrgasts);
            int i;
            for ( i = 0; i < fahrgasts.Count; i++)
            {
                if (testi[i].VName.Equals(f))
                {
                    break;
                }
            }
            return testi[i];
        }
        public void SetSeSv(Secret_Service a )
        {
            secret = a;
        }
    }
}
