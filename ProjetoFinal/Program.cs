bool vitoria, derrota, fim;
int vidas = 6;

string palavra = GerarPalavra().ToUpper();

char[] letrasCertas = palavra.ToUpper().ToCharArray();

char[] letrasTabuleiro = new char[palavra.Length];













//Método para gerar palavra aleatória de uma array
string GerarPalavra()
{
    Random rd = new Random();

    string[] palavras = {"Monitor", "Vizinho", "Gramado", "Toalha", "Terceiro", "Faringe", "Assustar", "Mordomo", "Rodovia", "Eternidade", "Capela",
        "Fluxo","Sardinha", "Pirata", "Ferro", "Difícil", "Trancar", "Casamento", "Cativeiro", "Descriçao", "Maremoto", "Coletivo", "Grafite", "Civilizaçao",
        "Vitoria", "Exemplo", "Adivinhar", "Xampu", "Personagem", "Traidor", "Cítrico", "Especular", "Afrouxar", "Laranjeira", "Composto", "Progenitor","Granizo", "Dispositivo",
        "Armadilha", "Poesia", "Umbilical", "Relacionamento", "Capacete", "Envelope", "Cronometragem",  "Calculadora", "Hipnotizar", "Marinheiro", "Perpetuo"};

    //teste de commit

    return palavras[rd.Next(palavras.Length)];
}
