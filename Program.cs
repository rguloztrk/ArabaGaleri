using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGaleri
{
    public class Program
    {
        static void Main(string[] args)
        {

            //DECORATOR DESENI Model Classinda
            Console.WriteLine("\n\n*********  DECORATOR DESENI ORNEGI  **********\n\n");
            Console.WriteLine("Uretimi yapilacak modelin renk secimi yapiliyor ::\n");
            Spor sp = new Spor();
            RedModelDecorator rSp = new RedModelDecorator(sp);
            rSp.ModelBelirt();

            IModel ab = new AileBoy();
            RedModelDecorator rd = new RedModelDecorator(ab);
            rd.ModelBelirt();
            Console.WriteLine("Renk secimi belirlendi!!\n");

            //Odeme Classinda STRATEGY Deseni
            Console.WriteLine("\n\n*********  STRATEGY DESENI ORNEGI  **********\n\n");
            Console.WriteLine("Odeme islemi olusturuluyor ::\n");
            OdemeContext oc = new OdemeContext(new Pesin());
            oc.OdeTipi("Pesin");

            OdemeContext oc2 = new OdemeContext(new Cek());
            oc2.OdeTipi("Cek");
            Console.WriteLine("Odeme islemi Sonlandirildi!!\n");

            //Marka classinda FACTORY DESENI
            Console.WriteLine("\n\n*********  FACTORY DESENI ORNEGI  **********\n\n");
            Console.WriteLine("Uretim icin markalar belirleniyor ::\n");
            MarkaFactory mf = new MarkaFactory();

            IMarka mark = mf.GetMarka("Audi");
            mark.MarkaUretimi();

            IMarka mark2 = mf.GetMarka("Ferrari");
            mark2.MarkaUretimi();
            Console.WriteLine("Uretimi yapilacak  markalar belirlendi!!\n");

            //Araba ve Model claasin da TEMPLATE deseni uygulandi
            Console.WriteLine("\n\n*********  TEMPLATE DESENI ORNEGI  **********\n\n");
            Console.WriteLine("Arac uretimi icin model tipi belirleniyor ::\n");
            Console.WriteLine("Jip tipi araba uretimi : \n");
            ArabaTemplate at = new Jip();
            at.ArabaUret();

            Console.WriteLine("Spor tipi araba uretimi : \n");
            ArabaTemplate at2 = new Spor();
            at2.ArabaUret();

            Console.WriteLine("Uretilecek model tipleri belirlendi!!\n");


            //TeknikSrvis islemleri icin STATE deseni uygulandi
            Console.WriteLine("\n\n*********  STATE DESENI ORNEGI  **********\n\n");
            Console.WriteLine("Teknik servis icin yapilacak islemler ::\n");
            TeknikServis t = new TeknikServis(120);
            //her islemgerceklestir() fonksiyonu icin farkli islemler yapiliyor olacak
            t.IslemGerceklestir();
            t.IslemGerceklestir();
            t.IslemGerceklestir();
            Console.WriteLine("Teknik Servis Islemi Tamamlandi!!\n");

            //Fiyat classina ADAPTER deseni uygulandi
            Console.WriteLine("\n\n*********  ADAPTER DESENI ORNEGI  **********\n\n");
            Console.WriteLine("Ust model uretimi icin fiyat belirlenecek :: \n");
            Console.WriteLine("Toyota Model Araba\n");
            Toyota2013 tyt = new Toyota2013();
            tyt.UstModelOlustur();
            tyt.UretimYiliniBelirt();
            tyt.FiyatBelirle();

            Console.WriteLine("Fiat Model Araba\n");
            Fiat2013 fiat = new Fiat2013();
            fiat.Model();
            fiat.UretimYili();
            fiat.Fiyat();

            Console.WriteLine("YENI UST Model Fiat \n");
            IFiyat fiyat = new Fiat2013Adapter(fiat);
            fiyat.UstModelOlustur();
            fiyat.UretimYiliniBelirt();
            fiyat.FiyatBelirle();
            Console.WriteLine("Ust model icin fiyatlar belirlendi\n");

            Console.ReadLine();
        }
    }
}
