using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGaleri
{
    public interface IFiyat
    {
        void UstModelOlustur();
        void UretimYiliniBelirt();
        void FiyatBelirle();
    }

    public class Toyota2013 : IFiyat
    {
        public void UstModelOlustur()
        {
            Console.WriteLine("- Ust model Toyota olusturuluyor\n");
        }

        public void UretimYiliniBelirt()
        {
            Console.WriteLine("- Yeni modelin uretim yili girilsin : ");
            int model = Int32.Parse(Console.ReadLine());            
            Console.WriteLine("\n- " + model + "  model Toyota uretildi\n");
        }

        public void FiyatBelirle()
        {
            Console.WriteLine("- Yeni model icin fiyat belirlensin : ");
            int fiyat = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n- Yeni model Toyota fiyati : " + fiyat+ "\n");
        }
    }

    public class Fiat2013 
    {
        public void Model()
        {
            Console.WriteLine("- Fiat model arac uretilecek\n");
        }
        public void UretimYili()
        {
            Console.WriteLine("- Modelin uretim yili girilsin : ");
            int model = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n - " + model + "  model Fiat uretildi\n");
        }
        public void Fiyat()
        {
            Console.WriteLine("- Model icin fiyat belirlensin : ");
            int fiyat = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n - Belirlenen fiyat : " + fiyat + "\n");
        }

    }

    public class Fiat2013Adapter : IFiyat
    {
        Fiat2013 fiat;

        public Fiat2013Adapter(Fiat2013 yeniModel)
        {
            fiat = yeniModel;
        }
        public void UstModelOlustur()
        {
            fiat.Model();
        }

        public void UretimYiliniBelirt()
        {
            fiat.UretimYili();
        }

        public void FiyatBelirle()
        {
            fiat.Fiyat();
        }
    }




    
}
