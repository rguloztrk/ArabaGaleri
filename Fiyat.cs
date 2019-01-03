using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGaleri
{
    public class Fiyat
    {
        public int Yil;
        public float Butce;
        public ArrayList ArabaFiyat;
        public ArrayList ModelFiyat;

        public Fiyat(int yil, float  butce)
        {
            this.Yil = yil;
            this.Butce = butce;
        }
    }
}
