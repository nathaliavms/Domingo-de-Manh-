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
            int diferenca = 0;
            if (Horas < 8 && Minutos < 01 || Horas < 7)
            {
                return 0;
            }
            else
            {
                diferenca = (Horas - 7) * 60 + Minutos;
                return  + diferenca;
            }
        }
        public override string ToString()
        {
            return "Atraso maximo: " + CalculoDeAtraso().ToString();     
        }
    }   
}
