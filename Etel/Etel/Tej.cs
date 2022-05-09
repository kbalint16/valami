using System;
using System.Collections.Generic;
using System.Text;

namespace Etel
{
    enum TejTipus
    {
        ZSIROS,
        FELZSIROS
    }
    enum AdagKiszereles
    {
        LITERES,
        FELLITERES,
        POHARAS
    }
    internal class Tej : Tejtermek, IComparable<Tej>
    {
        private int EladasiAr;
        private TejTipus Tipus;
        private AdagKiszereles Kiszereles;
        private TejTipus zSIROS;
        private AdagKiszereles lITERES;

        public Tej(int eladasiAr, TejTipus tipus, AdagKiszereles kiszereles, int egysegar, string gyarto, DateTime gyartasiIdo, DateTime lejaratiIdo)
            : base(egysegar,  gyarto,  gyartasiIdo,  lejaratiIdo)
        {
            EladasiAr = eladasiAr;
            Tipus = tipus;
            Kiszereles = kiszereles;

            float tipusszorzo = 1.0f;
            if (Tipus == TejTipus.FELZSIROS)
                tipusszorzo = 1.0f;
            else
                tipusszorzo = 1.4f;

            EladasiAr = (int)(egysegar * tipusszorzo);

        }
        public Tej(int egysegAr, string gyarto, DateTime gyartasiIdo, DateTime lejaratiIdo) : this(egysegAr, gyarto, gyartasiIdo, lejaratiIdo, TejTipus.ZSIROS, AdagKiszereles.LITERES)
        { }

        public Tej(int egysegar, string gyarto, DateTime gyartasiIdo, DateTime lejaratiIdo, TejTipus zSIROS, AdagKiszereles lITERES) : base(egysegar, gyarto, gyartasiIdo, lejaratiIdo)
        {
            this.zSIROS = zSIROS;
            this.lITERES = lITERES;
        }

        public int GetEladasiAr()
            => EladasiAr;

        public void SetEladasiAr(int v)
            => EladasiAr = v;

        public TejTipus GetTejTipus()
            => Tipus;

        public void SetTejtipus(TejTipus v)
            => Tipus = v;

        public AdagKiszereles GetKiszereles()
            => Kiszereles;

        public void SetAdagKiszereles(AdagKiszereles v)
            => Kiszereles = v;

        public override string ToString()
            => $"{EladasiAr}{Tipus}{Kiszereles}{base.ToString()}";

        public static Tej OlcsobbTej(Tej s1, Tej s2)
            => s1.EladasiAr <= s2.EladasiAr ? s1 : s2;

        public int CompareTo(Tej tej)
            => tej.EladasiAr;

    }

}
