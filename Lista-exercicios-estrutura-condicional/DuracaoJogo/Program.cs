namespace DuracaoJogo
{
    internal class Program
    {
        //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
        //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o horário em que o jogo começou:");
            int horaInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o horário em que o jogo terminou:");
            int horaFim = int.Parse(Console.ReadLine());

            if ( horaFim > horaInicio)
            {
                int duracaoPartida = horaFim - horaInicio;
                Console.WriteLine($"A partida durou {duracaoPartida} horas");
            }
            else
            {
                int duracaoPartida = 24 - horaInicio + horaFim;
                Console.WriteLine($"A partida durou {duracaoPartida} horas"); 
            }

        }
    }
}