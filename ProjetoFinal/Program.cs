using ProjetoFinal;

bool vitoria = false, derrota = false, fim = false;
int vidas = 6;
string mensagem="";

string palavra = GerarPalavra().ToUpper();

char[] letrasCertas = palavra.ToUpper().ToCharArray();


char[] letrasTabuleiro = new char[palavra.Length];
ConstruirArrayDoTabuleiro(letrasTabuleiro);

char[] jogadas = new char[27];

//Se fosse lista não precisaria desse iterador;
int iterador = 0;
string tema = Tema(palavra);

do
{
    Tabuleiro.ConstruirTabuleiro(vidas, letrasTabuleiro, jogadas, tema, mensagem);

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

    string[] palavras = { "AMARELO","BRANCO", "AZUL","VIOLETA","CACHORRO","PASSARINHO","GATO",
                    "PEIXE","PIJAMA","CUECA","CASACO","JAQUETA","ESTOJO","CADERNO", "TESOURA","CORRETIVO","BOLO","MOUSSE","LASANHA",
                    "PIZZA", "CANECA", "GARFO", "ESCUMADEIRA","PANELA","PEDIATRA","OFTALMOLOGISTA","CARDIOLOGISTA","NEUROLOGISTA"};

    //teste de commit

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



static string Tema(string palavra)
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