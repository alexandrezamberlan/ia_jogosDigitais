using Rainhas_Game;


int tamanhoPopulacao = 1000;
int tamanhoMatriz = 4;
List<Matriz> listaTabuleiros = new List<Matriz>();
for (int i = 0; i < tamanhoPopulacao; i++)
{
    listaTabuleiros.Add(new Matriz(tamanhoMatriz));
    listaTabuleiros[i].preencherMatriz();
    listaTabuleiros[i].verificarRestricoes();
    listaTabuleiros[i].exibirMatriz("Tabuleiro...." + i);
    if (listaTabuleiros[i].ehMeta())
    {
        Console.WriteLine("Achou!!!!!");
        break;
    }


}


//MeusTestes matrizTeste = new MeusTestes(3);
//matrizTeste.exibirMatriz();
//matrizTeste.mostrarDiagonaisPrincipais();

