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
            Console.WriteLine("- Arabanin markasi ferrari uretimidir\n");
        }
    }

    public class Audi : IMarka
    {
        public void MarkaUretimi()
        {
            Console.WriteLine("- Arabanin markasi audi uretimidir\n");
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
    
}
