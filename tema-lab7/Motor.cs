using System;
using System.Collections.Generic;
using System.Text;

namespace tema_lab7
{
    class Motor
    {
        private readonly int capCilindrica;
        private readonly int putere;
        private readonly string tipComb;

        public Motor(int capCilindrica, string tipComb, int putere)
        {
            this.capCilindrica = capCilindrica;
            this.tipComb = tipComb;
            this.putere = putere;
        }

        public int CapacitateCilindrica { get { return capCilindrica; } }
        public int Putere { get { return putere; } }
        public string TipComb { get { return tipComb; } }

        public void Start()
        {
            Console.WriteLine($"Brrr");
        }

        public void Stop()
        {
            Console.WriteLine($"par poc pac");
        }

       
    }


}
