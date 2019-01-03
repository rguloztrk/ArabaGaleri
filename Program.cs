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
            //Decorator DESENI Model Classinda
            Spor sp = new Spor();
            RedModelDecorator rSp = new RedModelDecorator(sp);
            rSp.ModelBelirt();

            IModel ab = new AileBoy();
            RedModelDecorator rd = new RedModelDecorator(ab);
            rd.ModelBelirt();

            //Odeme Classinda Strategy Deseni
            OdemeContext oc = new OdemeContext(new Pesin());
            oc.OdeTipi("Pesin");

            OdemeContext oc2 = new OdemeContext(new Cek());
            oc2.OdeTipi("Cek");

            //Marka classinda Factory DESENI
            MarkaFactory mf = new MarkaFactory();

            IMarka mark = mf.GetMarka("Audi");
            mark.MarkaUretimi();

            IMarka mark2 = mf.GetMarka("Ferrari");
            mark2.MarkaUretimi();

            Console.ReadLine();
        }
    }
}
