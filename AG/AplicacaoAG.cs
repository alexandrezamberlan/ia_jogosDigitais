public class AplicacaoAG {
    void main() {
        int tamanhoPopulacao;
		- quantidadeGeracoes
		- taxaSelecao / taxaReproducao
		- taxaMutacao
		- neste caso em especial, palavraFinal	

		inicializarPopulacao(populacao,tamanhoPopulacao,palavraFinal)
		ordenarPopulacao(populacao) //decrescente pela aptidao
		exibirPopulacao(populacao)

		laço 1 até quantidadeGeracoes
			selecionarPopulacao(populacao,novaPopulacao,taxaSelecao)
			reproduzirPopulacao(populacao,novaPopulacao,taxaReproducao,palavraFinal)
			
			mutarPopulacao(novaPopulacao,palavraFinal) //verificar a taxa ou a frequencia
			ordenarPopulacao(novaPopulacao)
			exibirPopulacao(novaPopulacao)

			apagar(populacao)
			mover(novaPopulacao,populacao)
			apagar(novaPopulacao)
    }
}