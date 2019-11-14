/*
 * Classe PERCEPTRON que aprende a resolução da tabela E
 */
 
class Perceptron_And {
 
    // pesos sinápticos:
    // [0] entrada 1, 
    // [1] entrada 2, 
    // [3] BIAS ou Limiar
    double[] pesos = new double[3];
 
    // variável responsável pelo somatório da rede
    double SOMATORIO_REDE = 0;
 
    // variável responsável pelo número máximo de gerações
    int geracoes = 100000;
 
    // variável responsável pela contagem das gerações durante o treinamento
    int conta = 0;
 
    // declara o vetor da matriz de aprendizado
    int[][] matrizAprendizado = new int[4, 3];
 
	// metodo de inicialização inicia o vetor da matriz de aprendizado
	Perceptron_And() {
 
		// Primeiro valor
		this.matrizAprendizado[0][0] = 0; // entrada 1
		this.matrizAprendizado[0][1] = 0; // entrada 2
		this.matrizAprendizado[0][2] = 0; // valor esperado
	 
		// Segundo Valor
		this.matrizAprendizado[1][0] = 0; // entrada 1
		this.matrizAprendizado[1][1] = 1; // entrada 2
		this.matrizAprendizado[1][2] = 0; // valor esperado
	 
		// terceiro valor
		this.matrizAprendizado[2][0] = 1; // entrada 1
		this.matrizAprendizado[2][1] = 0; // entrada 2
		this.matrizAprendizado[2][2] = 0; // valor esperado
	 
		// quarto valor
		this.matrizAprendizado[3][0] = 1; // entrada 1
		this.matrizAprendizado[3][1] = 1; // entrada 2
		this.matrizAprendizado[3][2] = 1; // valor esperado
	 
		// inicialização dos pesos sinápticos
		// Peso sináptico para primeira entrada.
		pesos[0] = 0;
		// Peso sináptico para segunda entrada.
		pesos[1] = 0;
		// Peso sináptico para o BIAS
		pesos[2]= 0;
 
	}

    // Função de Ativação tipo STEP
    int funcaoAtivacao(int u) {
        if (u >= 0) {
            return 1;
        }
        return 0;
    }
 
	// Método responsávelpelo somatório e a função de ativação.
    int executar(int x1, int x2) {
         // Somatório (SOMATORIO_REDE)
        SOMATORIO_REDE = (x1 * pesos[0]) + (x2 * pesos[1]) + ((-1) * pesos[2]);
 
        return funcaoAtivacao(SOMATORIO_REDE);
    }
 
    // Método para treinamento da rede
    public void treinar() {
         // variavel utilizada responsável pelo controlede treinamento recebefalso
        boolean treinou;
        // varável responsável para receber o valor da saída (y)
        int saida;
        do {
            treinou = true;
            // laço usado para fazer todas as entradas
            for (int i = 0; i < matrizAprendizado.length; i++) {
                // A saída recebe o resultado da rede que no caso é 1 ou 0
                saida = executar(matrizAprendizado[i][0], matrizAprendizado[i][1]);
        
                if (saida != matrizAprendizado[i][2]) {
                    // Caso a saída seja diferente do valor esperado
    
                    // os pesos sinápticos serão corrigidos, ou seja, calibrados
                    corrigirPeso(i, saida); 
                    // a variavél responsável pelo controlede treinamento recebe falso
                    treinou = false;   
                }
            }
            // acrescenta uma época
            this.conta++;
    
            // teste se houve algum erro duranteo treinamento e o número de geracoes
            //é menor qe o definido
        } while (!treinou && this.conta < this.geracoesMax);
    }    // fim do método para treinamento
 
    // Método para a correção de pesos
    void corrigirPeso(int i, int saida) {
        pesos[0] = pesos[0] + (1 * (matrizAprendizado[i][2] - saida) * matrizAprendizado[i][0]);
        pesos[1] = pesos[1] + (1 * (matrizAprendizado[i][2] - saida) * matrizAprendizado[i][1]);
        pesos[2] = pesos[2] + (1 * (matrizAprendizado[i][2] - saida) * (-1));
    }
 
    void testar() {
        Console.WriteLine(" Teste 01 para 0 and 0 " + executar(0, 0));
        Console.WriteLine(" Teste 02 para 0 and 1 " + executar(0, 1));
        Console.WriteLine(" Teste 03 para 1 and 0 " + executar(1, 0));
        Console.WriteLine(" Teste 05 para 1 and 1 " + executar(1, 1));
    }
}