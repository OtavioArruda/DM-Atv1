namespace Exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int convidadosNoivo = 300;
            int convidadosNoiva = 600;
            int convidadosPresentesNoivo = 400;
            int convidadosPresentesNoiva = 400;

            if(convidadosNoivo < convidadosNoiva || convidadosNoiva > convidadosNoivo) 
            {
                Console.WriteLine("O numero de convidados da noiva e maior que o do noivo");
            }

            if(convidadosNoiva >= convidadosPresentesNoiva && convidadosPresentesNoiva <= convidadosNoiva)
            {
                Console.WriteLine("O numero de convidados da noiva e maior que o numero de convidados presentes da noiva");
            }

            if(convidadosPresentesNoiva == convidadosPresentesNoivo)
            {
                Console.WriteLine("O numero de convidados presentes da noiva e igual aos convidados presentes do noivo");
            }

            if(!!(convidadosNoivo != convidadosNoiva))
            {
                Console.WriteLine("O numero de convidados na noiva e diferente dos convidados do noivo");
            }
        }
    }
}