using System;

namespace tema_lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Un autoturism detine un motor
                precum si un numar de usi. De asemenea autovehiculul este
                caracterizat de marca, model si an de fabricatie
                • Motorul
                 este caracterizat de
                 Capacitate cilindrica
                 Putere
                 Tipul combustibilului
                • Autoturismul va avea urmatoarele metode/proprietati
                 GetDescription
                 Va returna descrierea completa a autovehicolului sub forma unui sir de
                caractere
                 “Marca, model, anDeFabricatie,
                capacitate cilindrica, combustibil,
                putere motor, numar de usi
                In metoda Main, creati autoturisme si
                afisati-le descrierea
                Creati diagrama UML si salvati-o in
                git, alaturi de proiect
             */

            Motor motor = new Motor(2000, "BENZINA", 100);
            Autoturism autoturism = new Autoturism("skoda", "octavia", 2006, motor, 4);

            Motor motor1 = new Motor(1999, "Disel", 200);
            Autoturism autoturism1 = new Autoturism("bmw", "m3", 2009, motor1, 4);

            Motor motor2 = new Motor(3000, "Gaz", 150);
            Autoturism autoturism2 = new Autoturism("range", "sport", 2022, motor2, 4);

            autoturism.PornesteMasina();
            autoturism.OpresteMasina();

            Console.WriteLine(autoturism.GetDescription());
            Console.WriteLine(autoturism1.GetDescription());
            Console.WriteLine(autoturism2.GetDescription());

            Console.WriteLine(Autoturism.NrTotalAuto);
            if(Autoturism.Bolid != null)
            {
                Console.WriteLine(Autoturism.Bolid.GetDescription());
            }

        }
    }
}
