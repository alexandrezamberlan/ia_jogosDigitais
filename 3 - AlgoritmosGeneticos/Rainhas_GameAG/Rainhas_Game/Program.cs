using Rainhas_Game;

//pensar na dinamica do funcionamento do AG
List<Matriz> populacao = new List<Matriz>();
List<Matriz> novaPopulacao = new List<Matriz>();

//tamanhoPopulacao e tamanho do tabuleiro
int tamanhoPopulacao = 10;
int tamanhoMatriz = 4;
//quantidadeGeracoes
int qtdGeracoes = 400;
//taxaSelecao / taxaReproducao
int taxaSelecao = 30;
int taxaReproducao = 100 - taxaSelecao;
//taxaMutacao
int taxaMutacao = 5;

//inicializarPopulacao(populacao, tamanhoPopulacao)
AG.inicializarPopulacao(populacao, tamanhoPopulacao, tamanhoMatriz);

//ordenar crescente pela qtdRestricoesFalhas
AG.ordenarPopulacao(populacao);

//exibir a primeira geracao
AG.exibirPopulacao(populacao,"GERAÇÃO 1");

//gerar as proximas gerações
for (int i = 2; i <= qtdGeracoes;i++)
{
    AG.selecionarPopulacaoPorTorneio(populacao, novaPopulacao, taxaSelecao);
    AG.reproduzirPopulacao(populacao, novaPopulacao, taxaReproducao);
    //  AG.mutarPopulacao(novaPopulacao) //verificar a taxa ou a frequencia
    AG.ordenarPopulacao(novaPopulacao);
    AG.exibirPopulacao(novaPopulacao, "GERAÇÃO " + i);
    populacao.Clear();
    populacao.AddRange(novaPopulacao);
    novaPopulacao.Clear();
}
