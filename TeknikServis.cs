using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGaleri
{
    public interface IState
    {
       void Islem(TeknikServis t);
    }

    public class GirisYapildi : IState
    {
        public void Islem(TeknikServis t)
        {
            Console.WriteLine("- {0} aracin teknis servis girisi yapildi \n", t.AracSayisi);
            t.State = new ParcaBekliyor(); //context sinifimizdaki state sayesinde sonraki durum referans veriliyor
        }
    }

    public class ParcaBekliyor : IState
    {
        public void Islem(TeknikServis t)
        {
            Console.WriteLine("- {0} arac parca bekliyor\n", t.AracSayisi);
            t.State = new TeslimatYapilacak();//context sinifimizdaki state sayesinde sonraki durum referans veriliyor
        }
    }

    public class TeslimatYapilacak : IState
    {
        public void Islem(TeknikServis t)
        {
            Console.WriteLine("- {0} aracin teslimati yapilacak\n", t.AracSayisi);
            t.State = new GirisYapildi();//context sinifimizdaki state sayesinde sonraki durum referans veriliyor
        }
    }
        
    public class TeknikServis //Context Sinifi
    {
        public int AracSayisi { get; set; }
        public TeknikServis(int AracSayisi)
        {
            this.AracSayisi = AracSayisi;//teknik servise gelen arac sayisi tutuluyor
            State = new GirisYapildi();//teknik seviste islem gorecek araclarin girisi yapilacak
        }

        public IState _State { get; set; }  
        public IState State//Arayuzden nesne olusturularak islemler gerceklestirilmesi saglanacak
        {                   //Her classta kullanilarak islemleri belirleyebiliyoruz
            get { return _State; }
            set
            {
                _State = value;
            }
        }

        public void IslemGerceklestir()
        {
            State.Islem(this);
        }

    }
}
