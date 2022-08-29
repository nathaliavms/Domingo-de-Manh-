using System;
using System.Collections.Generic;
using System.Text;

namespace Feira
{
    class Horario
    {
        public int Horas { get;  private set; }
        public int Minutos { get; private set; }
        public int Diferenca { get; private set; }

        public Horario(int horas, int minutos)
        {
            Horas = horas;
            Minutos = minutos;
        }
        public void CalculoDeAtraso()
        {
            if (Horas < 8 && Minutos < 01 || Horas < 7)
            {
                Console.WriteLine("Atraso maximo: " + 0);
            }
            else
            {
                Diferenca = (Horas - 7) * 60 + Minutos;
                Console.WriteLine("Atraso maximo: " + Diferenca);
            }
        }
    }   
}
