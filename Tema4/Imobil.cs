using System;
namespace Tema4
{
    public class Imobil
    {
        public Imobil()
        {
            this.tipCasa = "";
            this.nrEtaje = 0;
            this.pret = 0.0d;
        }

        public Imobil(string tipCasa)
        {
            this.tipCasa = tipCasa;
            this.nrEtaje = 0;
            this.pret = 0.0d;
        }

        public Imobil(string tipCasa, int nrEtaje)
        {
            this.tipCasa = tipCasa;
            this.nrEtaje = nrEtaje;
            this.pret = 0.0d;
        }

        public Imobil(string tipCasa, int nrEtaje, double pret)
        {
            this.tipCasa = tipCasa;
            this.nrEtaje = nrEtaje;
            this.pret = pret;
        }

        public string tipCasa { get; set; }
        public int nrEtaje { get; set; }
        public double pret { get; set; }
    }
}
