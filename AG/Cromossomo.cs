public class Cromossomo {
    public string valor;
    public int aptidao;
    public int aptidaoPorcentagem;

    public Cromossomo(string valor, string palavraFinal) {
        this.valor = valor;
        this.aptidao = calcularAptidao(palavraFinal);
        this.aptidaoPorcentagem = 0;
    }

    public int calcularAptidao(string palavraFinal) {
        string x;
        int nota = 1;

        //fazer o calculo do fitness

        return nota;
    }
}
