% Sistemas de Comportamento Inteligente
%     - Base de conhecimento
%     - Raciocínio automatizado
%     - Aprendizado de máquina

% Representação e processamento do conhecimento -> base e raciocínio -> PROLOG
%     - Linguagem Prolog -> linguagem lógica escrita em sentenças ou predicados (relação)
%         - predicados:
%             - fatos - verdades que foram inseridos na base
%             - regras - hipóteses ou consultas para serem testadas na base
%         - naturalmente recursiva - ao invés de se ter instruções de repetição, há
%           processos/métodos recursivos (métodos que se chamam)
%         - naturalmente multithread - se houver mais de um core no processador, a 
%           linguagem divide o processamento, dando maior otimização de processamento

%exemplos de fatos

%personagem(nome, raça, categoria)
personagens(gandalf, humano, mago).
personagens(saruman, elfo, mago).
personagens(legolas, elfo, arqueiro).        
personagens(bilbo, hobbit, 'ladrão').
personagens(uruk,orc,rei).

%localizado(umLugar, outroLugar)
localizado(condado, leste).
localizado(valfenda, centro-oeste).
localizado("Abismo de Helm", noroeste).
localizado(leste, "Terra Media").
localizado(centro-oeste, "Terra Media").
localizado(noroeste, "Terra Media").
localizado(Lugar, OutroLugar) :- localizado(Lugar, Intermediario). %????

%raça(descricao,tempoVida, lingua)
raca(humano, 80, portugues).
raca(orc, 150, orcses).
raca(elfo, 1000, portugues).
raca("anão", 500, portugues).
raca(hobbit, 140, portugues).

%nasceu(nome, localizacao)
nasceu(gandalf, valfenda).
nasceu(legolas, valfenda).
nasceu(bilbo,condado).

%exemplos de regras - note que uma variável em regra começa com a letra MAIÚSCULA
nasceu(Alguem, Lugar) :- localizado(OutroLugar, Lugar),
                         nasceu(Alguem, OutroLugar).

tempoDeVida(Nome, T) :- personagens(Nome, Raca, Categoria),
                        Categoria == mago,
                        raca(Raca, Tempo),
                        T is Tempo + 100.

tempoDeVida(Nome, Tempo) :- personagens(Nome, Raca, _),
                            raca(Raca, Tempo).


aliados(Personagem1, Personagem2) :- personagens(Personagem1, Raca1, _),
                   personagens(Personagem2, Raca2, _),
                   Personagem1 \= Personagem2,
                   raca(Raca1, _, Lingua1),
                   raca(Raca2, _, Lingua2),
                   Lingua1 == Lingua2.