using System;
using System.Collections.Generic;
using System.Text;

namespace Etel
{
    class Tejtermek
    {
        private int Egysegar;
        private string Gyarto;
        private DateTime GyartasiIdo;
        private DateTime LejaratiIdo;

        public Tejtermek(int egysegar, string gyarto, DateTime gyartasiIdo, DateTime lejaratiIdo)
        {
            Egysegar = egysegar;
            Gyarto = gyarto;
            GyartasiIdo = gyartasiIdo;
            LejaratiIdo = lejaratiIdo;
        }

        public void SetEgysegar(int v)
            => Egysegar = v;

        public int GetEgysegar()
            => Egysegar;

        public void SetGyarto(string v)
            => Gyarto = v;

        public string GetGyarto()
            => Gyarto;

        public void SetGyartasiIdo(DateTime v)
            => GyartasiIdo=v;

        public DateTime GetGyartasiIdo()
            => GyartasiIdo;

        public void SetLejaratiIdo(DateTime v)
            => LejaratiIdo = v;

        public DateTime GetLejaratiiIdo()
            => LejaratiIdo;


        public bool IhatoE()
            => LejaratiIdo > DateTime.Now;

        public override string ToString()
            => $"{Egysegar}{Gyarto}{GyartasiIdo}{LejaratiIdo}";
    }
}
