using System;


namespace Feira
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Digite o horário que acordou: ");
                string[] HorarioInformado = Console.ReadLine().Split(":");
                var horas = int.Parse(HorarioInformado[0]);
                var minutos = int.Parse(HorarioInformado[1]);

                Horario Horario = new Horario(horas, minutos);
                Horario.CalculoDeAtraso();
            }
        }
    }
}
