bool vitoria = false, derrota = false, fim = false;
int vidas = 6;

string palavra = GerarPalavra().ToUpper();

char[] letrasCertas = palavra.ToUpper().ToCharArray();


char[] letrasTabuleiro = new char[palavra.Length];
ConstruirArrayDoTabuleiro(letrasTabuleiro);

char[] jogadas = new char[27];

//Se fosse lista não precisaria desse iterador;
int iterador = 0;

do
{
    ConstruirTabuleiro(vidas, letrasTabuleiro, jogadas);

    char jogada = Jogada();

    if (LetraValida(jogada))
    {
        if (!jogadas.Contains(jogada))
        {
            jogadas[iterador] = jogada;
            iterador++;
            bool acerto = false;

            for(int i = 0; i < letrasCertas.Length; i++)
            {
                if (letrasCertas[i] == jogada)
                {
                    letrasTabuleiro[i] = jogada;
                    acerto = true;
                }
            }
            if (!acerto)
            {
                vidas--;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"\nA letra '{jogada}' já foi selecionada! Tente de novo\n");
            continue;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"\n'{jogada}' não é uma letra do alfabeto. Por favor, insira uma letra do alfabeto válida!\n");
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



//Método para gerar palavra aleatória de uma array
string GerarPalavra()
{
    Random rd = new Random();

    string[] palavras = {"Monitor", "Vizinho", "Gramado", "Toalha", "Terceiro", "Faringe", "Assustar", "Mordomo", "Rodovia", "Eternidade", "Capela",
        "Fluxo","Sardinha", "Pirata", "Ferro", "Difícil", "Trancar", "Casamento", "Cativeiro", "Descriçao", "Maremoto", "Coletivo", "Grafite", "Civilizaçao",
        "Vitoria", "Exemplo", "Adivinhar", "Xampu", "Personagem", "Traidor", "Cítrico", "Especular", "Afrouxar", "Laranjeira", "Composto", "Progenitor","Granizo", "Dispositivo",
        "Armadilha", "Poesia", "Umbilical", "Relacionamento", "Capacete", "Envelope", "Cronometragem",  "Calculadora", "Hipnotizar", "Marinheiro", "Perpetuo"};

    return palavras[rd.Next(palavras.Length)];
}

char[] ConstruirArrayDoTabuleiro(char[] letrasTabuleiro)
{
    for (int i = 0; i < letrasTabuleiro.Length; i++)
    {
        letrasTabuleiro[i] = '_';
    }
    return letrasTabuleiro; 
}

void ConstruirTabuleiro(int vida, char[] letraTabuleiro, char[] jogadas)
{
    Console.WriteLine(" *_____*");
    Console.WriteLine($" |/    '         Vidas: {vidas}");
    Console.WriteLine(" |");
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

char Jogada()
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

bool LetraValida(char jogada)
{
    //todas as letras do alfabeto
    char[] alfabeto = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
    'M', 'N', 'O', 'P', 'Q', 'R','S','T','U','V','W', 'X', 'Y', 'Z', };

    if (alfabeto.Contains(jogada))
    {
        return true;
    }
    else
    {
        return false;
    }
}