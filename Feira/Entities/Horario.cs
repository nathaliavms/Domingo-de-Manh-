using System;

namespace Feira
{
    class CalcularHoraDaFeira
    {
        private int Horas { get; set; }
        private int Minutos { get; set; }
        public CalcularHoraDaFeira(int horas, int minutos)
        {
            Horas = horas;
            Minutos = minutos;
        }
        private int CalculoDeAtraso()
        {
            int diferença;
            if (Horas < 8 && Minutos < 01 || Horas < 7)
            {
                return 0;
            }
            else
            {
                diferença = (Horas - 7) * 60 + Minutos;
                return  + diferença;
            }
        }
        public override string ToString()
        {
            return "Atraso maximo: " + CalculoDeAtraso().ToString();     
        }
    }   
}
