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

    public class Spor : ArabaTemplate, IModel
    {
        public void ModelBelirt()
        {
            Console.WriteLine("- Arabanin modeli spor araba modelidir\n");
        }

        protected override void MotorUretimi()
        {
            Console.WriteLine("- Spor araba tipi icin 8x8 motor uretiliyor\n");
        }

        protected override void TekerUretimi()
        {
            Console.WriteLine("- Spor araba uretimi icin surtunme katsayisi dusuk tipli tekerlek uretiliyor\n");
        }
    }

    public class Jip : ArabaTemplate ,IModel
    {
        public void ModelBelirt()
        {
            Console.WriteLine("- Arabanin modeli jip tipi araba modelidir\n");
        }

        protected override void MotorUretimi()
        {
            Console.WriteLine("- Jip icin 4x4 motor uretimi yapiliyor\n");
        }

        protected override void TekerUretimi()
        {
            Console.WriteLine("- Jip tipli araclar icin buyuk boy teker uretimi yapiliyor\n");
        }
    }

    public class AileBoy :ArabaTemplate ,IModel
    {
        public void ModelBelirt()
        {
            Console.WriteLine("- Arabanin modeli aile boyu modelidir\n");
        }

        protected override void MotorUretimi()
        {
            Console.WriteLine("- Aileboy tipli araba icin diesel motor uretimi yapiliyor\n");
        }

        protected override void TekerUretimi()
        {
            Console.WriteLine("- Aileboy icin normal ve kar lastigi uretimi yapiliyor\n");
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
            Console.WriteLine("- Model kirmizi renklidir\n");
        }
    }
    



    

    
}
