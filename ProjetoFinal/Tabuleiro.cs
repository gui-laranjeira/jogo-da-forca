using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Tabuleiro
    {
        public static void ConstruirTabuleiro(int vidas, char[] letrasTabuleiro, char[] jogadas, string tema, string mensagem)
        {
            Console.WriteLine(" *_____*");
            Console.WriteLine($" |/    '         Vidas: {vidas} - Dica: {tema}");
            Console.WriteLine($" |               {mensagem}");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.Write(" |");

            foreach (var a in letrasTabuleiro)
            {
                Console.Write(a + " ");
            }

            Console.Write("\nLetras escolhidas =  ");
            foreach (var b in jogadas)
            {
                Console.Write(b + " ");
            }
        }
    }
}
