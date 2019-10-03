

public class Util {
    public static letras = " abcdefghijklmnopqrstuvwxyz";

    public static string gerarPalavras(int quantidadeCaracteres) {
        string palavra;
        Random gerador = new Random();
        for (int i = 0; i < quantidadeCaracteres; i++) {
            palavra.append(letras.charAt(gerador.next(letras.size())));
        }
        return palavra;
    }
}