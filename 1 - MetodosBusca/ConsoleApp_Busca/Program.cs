using ConsoleApp_Busca;

Grafo exemplo1 = new Grafo(7);
List<string> cidades = new List<string>();
cidades.Add("a");
cidades.Add("b");
cidades.Add("c");
cidades.Add("d");
cidades.Add("e");
cidades.Add("f");
cidades.Add("g");

//a = 0; b = 1; c = 2, d = 3, e = 4
//exemplo1.inserirAssimetrico(cidades.IndexOf("a"), cidades.IndexOf("b"), 100);
//exemplo1.inserirAssimetrico(cidades.IndexOf("a"), cidades.IndexOf("e"), 10);
//exemplo1.inserirAssimetrico(cidades.IndexOf("b"), cidades.IndexOf("c"), 20);
//exemplo1.inserirAssimetrico(cidades.IndexOf("c"), cidades.IndexOf("d"), 10);
//exemplo1.inserirAssimetrico(cidades.IndexOf("c"), cidades.IndexOf("g"), 50);
//exemplo1.inserirAssimetrico(cidades.IndexOf("e"), cidades.IndexOf("c"), 100);
//exemplo1.inserirAssimetrico(cidades.IndexOf("e"), cidades.IndexOf("f"), 20);
//exemplo1.inserirAssimetrico(cidades.IndexOf("f"), cidades.IndexOf("g"), 30);
//exemplo1.inserirAssimetrico(cidades.IndexOf("g"), cidades.IndexOf("b"), 40);
//exemplo1.inserirAssimetrico(cidades.IndexOf("g"), cidades.IndexOf("d"), 100);

exemplo1.inserirSimetrico(cidades.IndexOf("a"), cidades.IndexOf("b"), 1);
exemplo1.inserirSimetrico(cidades.IndexOf("a"), cidades.IndexOf("e"), 1);
exemplo1.inserirSimetrico(cidades.IndexOf("b"), cidades.IndexOf("c"), 1);
exemplo1.inserirSimetrico(cidades.IndexOf("b"), cidades.IndexOf("f"), 1);
exemplo1.inserirSimetrico(cidades.IndexOf("c"), cidades.IndexOf("d"), 1);
exemplo1.inserirSimetrico(cidades.IndexOf("c"), cidades.IndexOf("e"), 1);
exemplo1.inserirSimetrico(cidades.IndexOf("d"), cidades.IndexOf("e"), 1);
exemplo1.inserirSimetrico(cidades.IndexOf("e"), cidades.IndexOf("f"), 1);
exemplo1.inserirSimetrico(cidades.IndexOf("e"), cidades.IndexOf("g"), 1);


exemplo1.exibirGrafo(cidades);

Console.Write("Nome da cidade de origem: ");
string origem = Console.ReadLine();
Console.Write("Nome da cidade de destino: ");
string destino = Console.ReadLine();

Console.WriteLine("\nBusca amplitude");
Busca.mostraCaminhoAmplitude(cidades.IndexOf(origem), cidades.IndexOf(destino), exemplo1, cidades);

Console.WriteLine("\nBusca profundidade");
Busca.mostraCaminhoProfundidade(cidades.IndexOf(origem), cidades.IndexOf(destino), exemplo1, cidades);


