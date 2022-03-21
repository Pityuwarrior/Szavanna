using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2022._03._21_Szavanna
{
    internal abstract class Allat : IVanHelye
    {
        public int Eletkor { get; set; }
        public int MaxEletkor { get; set; }
        public int Ehseg { get; set; }
        public bool Nem { get; set; }
        public bool El { get; set; }
        public (int O, int S) Hely { get; set; }

        public Szavanna Szavanna { get; set; }

        public void Oregszik()
        {
            throw new NotImplementedException();
        }

        private List<IVanHelye> KornyezoMezok() 
        {
            var kornyezoMezok = new List<IVanHelye>();

            var ks = this.Hely.S == 0 ? 0 : this.Hely.S - 1;
            var ko = this.Hely.O == 0 ? 0 : this.Hely.O - 1;
            
            var vo = this.Hely.O ==  this.Szavanna.Terulet.GetLength(1) - 1
                ? this.Szavanna.Terulet.GetLength(1) - 1 : this.Hely.O + 1;

            var vs = this.Hely.S == this.Szavanna.Terulet.GetLength(1) - 1
               ? this.Szavanna.Terulet.GetLength(1) - 1 : this.Hely.S + 1;




            for (int o = 0; o < this.Szavanna.Terulet.GetLength(0); o++)
            {
                for (int s = 0; s < Szavanna.Terulet.GetLength(1); s++)
                {
                    if (true)
                    {

                    }
                }
            }
            
            return null;
        }

        protected bool TudSzulni
        {
            get 
            {
                if (this.Nem) return false;
                //ehes?
                if (this.Ehseg != 0) return false;
                {

                }
             //van-e kivel
             //ivarerett
             //mikor szaporodott
             //van-e hova
            }
        }
        public abstract Allat Szul();
        public abstract bool Eszik();
        public void Mozog() 
        {
            throw new NotImplementedException();
        }
    }


}
