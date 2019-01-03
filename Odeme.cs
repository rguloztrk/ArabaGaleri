using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGaleri
{
    public interface IStrategy
    {
        void OdemeTipi(string OTuru);
    }

    public class Pesin : IStrategy
    {
        public void OdemeTipi(string OTuru)
        {
            Console.WriteLine("- Odeme nakit yapilacaktir\n");
        }
    }

    public class Kredili : IStrategy
    {
        public void OdemeTipi(string OTuru)
        {
            Console.WriteLine("- Odeme kredili yapilacaktir\n");
        }
    }

    public class Cek : IStrategy
    {
        public void OdemeTipi(string OTuru)
        {
            Console.WriteLine("- Odeme cek ile yapilacaktir\n");
        }
    }
    public class OdemeContext
    {
        IStrategy OdemeTip;
        public OdemeContext(IStrategy odemeTip)
        {
            OdemeTip = odemeTip;
        }
        public void OdeTipi(string Oturu)
        {
            OdemeTip.OdemeTipi(Oturu);
        }
    }
}
