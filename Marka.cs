using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGaleri
{
    public interface IMarka
    {
        void MarkaUretimi();
    }

    public class Ferrari : IMarka
    {
        public void MarkaUretimi()
        {
            Console.WriteLine("Arabanin markasi ferrari uretimidir");
        }
    }

    public class Audi : IMarka
    {
        public void MarkaUretimi()
        {
            Console.WriteLine("Arabanin markasi audi uretimidir");
        }
    }

    public class MarkaFactory
    {
        public IMarka GetMarka(string markaAdi)
        {
            if (markaAdi == null)
                return null;
            else if (markaAdi.Equals("Audi"))
                return new Audi();
            else if (markaAdi.Equals("Ferrari"))
                return new Ferrari();

            return null;
        }
    }
    public class Marka
    {
        public string MarkaIsmi;
        public ArrayList ArabaMrk;
        public Model MarkaModel;

        public Marka(string markaisim)
        {
            this.MarkaIsmi = markaisim;
        }
        public void ArabaMarkaEkle(Araba arabaEkle)
        {
            if (ArabaMrk == null)
            {
                ArabaMrk = new ArrayList();
            }
            this.ArabaMrk.Add(arabaEkle);
        }
    }
}
