using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGaleri
{
   
    public abstract class ArabaTemplate //Model sinifindaki turlere uygulandi
    {
        protected virtual bool ModifiyeOlmusMu()
        {
            return false;
        }

        protected void ArabaKalibiCikar()
        {
            Console.WriteLine("- Arabanin model kalibi olusturuluyor\n");
        }

        protected abstract void MotorUretimi();//arabanin tipine gore motor gucu degiskenlik gosterir 4x4 8x8 beygir gucu vs.

        protected void BoyamaIslemi()
        {
            Console.WriteLine("- Araba boyama isleminden geciyor\n");
        }

        protected abstract void TekerUretimi();//arabanin tipine gore teker boyutu surtunme seviyesi vs

        public void ArabaUret()
        {
            ArabaKalibiCikar();
            MotorUretimi();
            BoyamaIslemi();
            TekerUretimi();
        }


    }


}
