using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class BaseJogo
    {
        //Método para gerar palavra aleatória de uma array
        public static string GerarPalavra()
        {
            Random rd = new Random();

            string[] palavras = { "AMARELO","BRANCO", "AZUL","VIOLETA","CACHORRO","PASSARINHO","GATO",
                    "PEIXE","PIJAMA","CUECA","CASACO","JAQUETA","ESTOJO","CADERNO", "TESOURA","CORRETIVO","BOLO","MOUSSE","LASANHA",
                    "PIZZA", "CANECA", "GARFO", "ESCUMADEIRA","PANELA","PEDIATRA","OFTALMOLOGISTA","CARDIOLOGISTA","NEUROLOGISTA"};

            //teste de commit
            var ramdom = rd.Next(palavras.Length - 1);
            return palavras[ramdom];
        }

        public static char[] ConstruirArrayDoTabuleiro(char[] letrasTabuleiro)
        {
            for (int i = 0; i < letrasTabuleiro.Length; i++)
            {
                letrasTabuleiro[i] = '_';
            }
            return letrasTabuleiro;
        }

        public static string Tema(string palavra)
        {
            string tematica = " * ";

            switch (palavra)
            {
                case "AMARELO":
                case "BRANCO":
                case "AZUL":
                case "VIOLETA":
                    tematica = "COR";
                    break;

                case "CACHORRO":
                case "PASSARINHO":
                case "GATO":
                case "PEIXE":
                    tematica = "BICHINHO DE ESTIMAÇÃO";
                    break;

                case "PIJAMA":
                case "CUECA":
                case "CASACO":
                case "JAQUETA":
                    tematica = "VESTIMENTA";
                    break;

                case "ESTOJO":
                case "CADERNO":
                case "TESOURO":
                case "CORRETIVO":
                    tematica = "MATERIAL ESCOLAR";
                    break;

                case "BOLO":
                case "MOUSSE":
                case "LASANHA":
                case "PIZZA":
                    tematica = "COMIDA";
                    break;

                case "CANECA":
                case "GARFO":
                case "ESCUMADEIRA":
                case "PANELA":
                    tematica = "UTENSILIOS DE COZINHA";
                    break;

                case "PEDIATRA":
                case "OFTALMOLOGISTA":
                case "CARDIOLOGISTA":
                case "NEUROLOGISTA":
                    tematica = "ESPECIALIDADE MEDICA";
                    break;


            }
            return tematica;
        }

        public static char Jogada()
        {
            bool convert;
            do
            {
                Console.WriteLine("\n\n\nDigite uma letra:");
                string jogadaString = Console.ReadLine().ToUpper();

                convert = char.TryParse(jogadaString, out char jogada);

                return jogada;
            } while (!convert);
        }
    }
}
