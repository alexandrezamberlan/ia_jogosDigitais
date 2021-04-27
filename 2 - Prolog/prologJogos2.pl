%o exército azul tem 100 soldados, enquanto o exército vermelho tem 200
%soldados. O azul, tem um general, dois capitães, 10 tenentes. O vermelho
%tem um general, 5 capitães, 5 tenentes.
%o exército azul está posicionado a esquerda do rio guaiba, enquanto
%que o vermelho está a direita. O azul está sob o monte diamante, enquanto
%o vermelho está sob a planície de fogo

exercito(azul,100).
exercito(vermelho,200).
exercito(dourado,1000).

general(1,azul).
general(1,vermelho).
general(3,dourado).

capitao(2,azul).
capitao(5,vermelho).
capitao(10,dourado).

tenente(10,azul).
tenente(5,vermelho).
tenente(20,dourado).

relevo(morro,diamante).
relevo(planicie,fogo).

estaPosicionado(azul,esquerda,guaiba).
estaPosicionado(vermelho,direita,guaiba).
estaPosicionado(azul,sobre, diamante).
estaPosicionado(vermelho, sobre, fogo).
estaPosicionado(dourado,esquerda,guaiba).

altoEscalao(Quantidade, Exercito) :- general(Q1, Exercito),
                                     capitao(Q2, Exercito),
    								 Quantidade is Q1 + Q2.

aliado(Exercito1, Exercito2) :- exercito(Exercito1,_),
                                exercito(Exercito2,_),
                                estaPosicionado(Exercito1,Lugar,guaiba),
                                estaPosicionado(Exercito2,Lugar,guaiba),
                                Exercito1 \== Exercito2.
                          
vantagem(Exercito1, Exercito2) :- exercito(Exercito1, Q1),
                                  exercito(Exercito2, Q2),
                                  Q is Q2 * 2,
								  Q1 > Q,
                                  writeln( " possui mais efetivo em dobro").

vantagem(Exercito1, Exercito2) :- exercito(Exercito1,_),
                                  exercito(Exercito2,_),
                                  estaPosicionado(Exercito1,sobre,Nome1),
    							  relevo(Relevo1,Nome1),
                                  Relevo1 == morro,
                                  Exercito1 \== Exercito2,
                                  estaPosicionado(Exercito2,sobre,Nome2),
                                  relevo(Relevo2,Nome2),
                                  Relevo2 \== morro,
                                  writeln(" esta melhor posicionado no campo de batalha").

vantagem(Exercito1, Exercito2) :- aliado(Exercito1, _),
                                  not(aliado(Exercito2,_)),
                                  writeln("possui o aliado ").