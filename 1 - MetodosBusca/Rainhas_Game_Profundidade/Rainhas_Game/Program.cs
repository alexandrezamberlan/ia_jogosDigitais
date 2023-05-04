using Rainhas_Game;



int tamanhoMatriz = 6;
Matriz tabuleiro = new Matriz(tamanhoMatriz);

tabuleiro.exibirMatriz("Tabuleiro inicial .... sem rainhas....");

//if (tabuleiro.haRestricoes())
//{
//    Console.WriteLine("Simm");
//} else
//{
//    Console.WriteLine("Não");
//}


if (tabuleiro.resolveRainhas(1))
{
    tabuleiro.exibirMatriz("\n\nCenário resolvido com sucesso!");
}
else
{
    Console.WriteLine("Cenário não resolvido! A configuração inicial do rainhas está complexa!");
}
