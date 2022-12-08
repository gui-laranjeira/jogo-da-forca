using ProjetoFinal;

bool vitoria = false, derrota = false, fim = false;
int vidas = 6;
string mensagem="";

string palavra = BaseJogo.GerarPalavra().ToUpper();

char[] letrasCertas = palavra.ToUpper().ToCharArray();


char[] letrasTabuleiro = new char[palavra.Length];
BaseJogo.ConstruirArrayDoTabuleiro(letrasTabuleiro);

char[] jogadas = new char[27];

//Se fosse lista não precisaria desse iterador;
int iterador = 0;
string tema = BaseJogo.Tema(palavra);

do
{
    Tabuleiro.ConstruirTabuleiro(vidas, letrasTabuleiro, jogadas, tema, mensagem);

    char jogada = BaseJogo.Jogada();

    try
    {
        Validacao.LetraValida(jogada);

        if (!jogadas.Contains(jogada))
        {

            jogadas[iterador] = jogada;
            iterador++;
            bool acerto = false;


            for (int i = 0; i < letrasCertas.Length; i++)
            {
                if (letrasCertas[i] == jogada)
                {
                    letrasTabuleiro[i] = jogada;
                    acerto = true;
                    mensagem = "";

                }
            }
            if (!acerto)
            {
                mensagem = $"A letra '{jogada}' não existe na palavra-chave!";
                vidas--;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"\nA letra '{jogada}' já foi selecionada! Tente de novo\n");
            mensagem = "";
            continue;
        }
    }
    catch (Exception e)
    {
        Console.Clear();
        Console.WriteLine(e.Message);
        continue;
    }
         
    Console.Clear();

    //Verifica se o jogo acabou
    if(vidas < 1)
    {
        derrota = true;
        fim = true;
    }
    else if (!letrasTabuleiro.Contains('_'))
    {
        vitoria = true;
        fim = true;
    }

} while (!fim);

if (vitoria)
{
    Console.WriteLine($"Parabéns, você venceu! A palavra era '{palavra}'. Sobraram {vidas} vidas");
}
else if (derrota)
{
    Console.WriteLine($"Infelizmente você perdeu :(. A palavra correta era: '{palavra}'");
}







