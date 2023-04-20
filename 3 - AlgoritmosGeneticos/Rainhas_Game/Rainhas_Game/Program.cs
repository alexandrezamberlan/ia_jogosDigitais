using Rainhas_Game;


int tamanhoPopulacao = 100000;
List<Matriz> listaTabuleiros = new List<Matriz>();  
for (int i = 0; i < tamanhoPopulacao; i++)
{
    listaTabuleiros.Add( new Matriz(5) );
    listaTabuleiros[i].preencherMatriz();
    listaTabuleiros[i].verificarRestricoes();
    listaTabuleiros[i].exibirMatriz("Tabuleiro...." + i);
    if (listaTabuleiros[i].ehMeta())
    {
        Console.WriteLine("Achou!!!!!");
        break;
    }


}


