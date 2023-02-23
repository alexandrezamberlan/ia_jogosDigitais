using ConsoleApp_Busca;

Grafo exemplo1 = new Grafo(5);
List<string> cidades = new List<string>();
cidades.Add("a");
cidades.Add("b");
cidades.Add("c");
cidades.Add("d");
cidades.Add("e");

//a = 0; b = 1; c = 2, d = 3, e = 4
exemplo1.inserirAssimetrico(cidades.IndexOf("a"), cidades.IndexOf("b"), 10);
exemplo1.inserirAssimetrico(cidades.IndexOf("b"), cidades.IndexOf("a"), 10);
exemplo1.inserirAssimetrico(cidades.IndexOf("b"), cidades.IndexOf("d"), 20);
exemplo1.inserirAssimetrico(cidades.IndexOf("c"), cidades.IndexOf("e"), 10);
exemplo1.inserirAssimetrico(cidades.IndexOf("d"), cidades.IndexOf("c"), 40);
exemplo1.inserirAssimetrico(cidades.IndexOf("d"), cidades.IndexOf("e"), 20);

exemplo1.exibirGrafo(cidades);
