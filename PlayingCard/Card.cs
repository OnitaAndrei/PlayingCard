using System;

namespace Playingcarte
{
    internal class carte
    {
        int nr, culoare;
        public static int As= 1,Doiar=2,Treiar=3,Patrar=4,Cinci=5,Sase=6,Septar=7,Opt=8,Noua=9,Zeaca=10,Juvete=11,Dama=12,Popa=13,Carou=1,Trefla=2,InimaR=3,InimaN=4;
        bool isnr(int nr)
        { 
            if (As <= nr && nr <= Popa)
                return true;
            return false;
         }   

        bool isculoare(int culoare)
        {
            if(Carou <= culoare && culoare <= InimaN)
                return true;
            return false;
        }

        public carte(int nr, int culoare)
        {
            bool isnrBool = isnr(nr), isculoareBool = isculoare(culoare); 
            if (!isnrBool)
                throw new ArgumentException("Numar invalid");
            if (!isculoareBool)
                throw new ArgumentException("Culoare invalida");
            this.nr = nr;
            this.culoare = culoare;
        }

        public int getnr() { return nr; }
        public int getculoare() { return culoare; }
        public static String nrToString(int nr)
        {
            switch (nr)
            {
                case 1:
                    return "As";
                case 2:
                    return "Doi";
                case 3:
                    return "Trei";
                case 4:
                    return "Patru";
                case 5:
                    return "Cinci";
                case 6:
                    return "Sase";
                case 7:
                    return "Sapte";
                case 8:
                    return "Opt";
                case 9:
                    return "Noua";
                case 10:
                    return "Zece";
                case 11:
                    return "Juvete";              
                case 12:
                    return "Dama";
                case 13:
                    return "Popa";
                default:
                    return null;
            }
        }
        public static String culoareToString(int culoare)
        {
            switch(culoare)
            {
                case 1:
                    return "de Carou";
                case 2:
                    return "de Trefla";
                case 3:
                    return "de Inima Rosie";
                case 4:
                    return "de Inima Neagra";
                default:
                    return null;

            };
        }
    }
}
