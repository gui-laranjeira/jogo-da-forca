bool vitoria, derrota, fim;
int vidas = 6;

string palavra = GerarPalavra().ToUpper();

char[] letrasCertas = palavra.ToUpper().ToCharArray();

char[] letrasTabuleiro = new char[palavra.Length];

string tema = Tema(palavra);












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