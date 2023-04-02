using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tema_lab7
{
    class Autoturism
    {
        private static void AddAuto(Autoturism auto)
        {
            NrTotalAuto++;
            if (Bolid == null ||  auto.motor.Putere > Bolid.motor.Putere)
            {
                Bolid = auto;
            }
        }
        private readonly string marca = "";
        private readonly string model = "";
        private readonly int anFabricatie;
        public Motor motor;
        public Usa[] usi;

        public static int NrTotalAuto { get; private set; }
        public static Autoturism Bolid { get; private set; }

        public Autoturism(string marca, string model, int anFabricatie, 
            Motor motor, int nrUsi)
        {
            this.marca = marca;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.motor = motor;

            usi = new Usa[nrUsi];
            for(var i=0; i<nrUsi; i++)
            {
                usi[i] = new Usa();
            }

            AddAuto(this);

        }

        public string GetDescription()
        {
            
           return @$"Marca {this.marca}, model {this.model}, 
                anDeFabricatie {this.anFabricatie},
                capacitate cilindrica {motor.CapacitateCilindrica},
                combustibil {motor.TipComb}, putere motor {motor.Putere},
                numar de usi {usi.Length}";
        }

        public void PornesteMasina()
        {
            Console.WriteLine($"masina porneste");
            foreach(Usa usa in usi)
            {
                usa.Inchide();
            }
            this.motor.Start();
        }

        public void OpresteMasina()
        {
            Console.WriteLine($"masina se opreste");
            this.motor.Stop();
            foreach (Usa usa in usi)
            {
                usa.Deschide();
            }
        }

        /*
         Clasa autoturism
        - va detine o metoda prin care va fi calculat
        numarul total de autoturisme create
        - Va detine o metoda care va returna cel mai
        puternic autovehicul creat.
         */

    }
}
