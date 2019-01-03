using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGaleri
{
    public interface IModel
    {
        void ModelBelirt();
    }

    public class Spor : IModel
    {
        public void ModelBelirt()
        {
            Console.WriteLine("Arabanin modeli spor araba modelidir");
        }
    }

    public class Jip : IModel
    {
        public void ModelBelirt()
        {
            Console.WriteLine("Arabanin modeli jip tipi araba modelidir");
        }
    }

    public class AileBoy : IModel
    {
        public void ModelBelirt()
        {
            Console.WriteLine("Arabanin modeli aile boyu modelidir");
        }
    }

    public abstract class ModelDecorator : IModel
    {
        protected IModel model;
        public ModelDecorator(IModel modell)
        {
            model = modell;
        }

        public void ModelBelirt()
        {
            model.ModelBelirt();
        }
    }

    public class RedModelDecorator : ModelDecorator , IModel
    {
        public RedModelDecorator(IModel ml) : base(ml)
        {

        }

        public void ModelBelirt()
        {
            model.ModelBelirt();
            Console.WriteLine("Model kirmizi renklidir");
        }
    }
    public class Model
    {
        public int Yil;
        public string ModelIsmi;
        public ArrayList Araba;
        public ArrayList Marka;

        public Model(int yil, string modelisim)
        {
            this.Yil = yil;
            this.ModelIsmi = modelisim;
        }

        public void ArabaEkle(Araba arabaEkle)
        {
            if(Araba == null)
            {
                Araba = new ArrayList();
            }
            this.Araba.Add(arabaEkle);
        }

        public void MarkaEkle(Marka markaEkle)
        {
            if (Marka == null)
            {
                Marka = new ArrayList();
            }
            this.Marka.Add(markaEkle);
        }




    }

    
}
