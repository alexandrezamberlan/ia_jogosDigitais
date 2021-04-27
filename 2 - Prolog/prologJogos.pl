%REPRESENTAÇÃO DO CONHECIMENTO VIA LINGUAGEM PROLOG
%	- IA Simbólica
%		- um código Prolog é um conjunto de:
%			- Predicados/Proposições/Sentenças/Afirmações
%				- FATOS (verdades inquestionáveis)
%				- REGRAS (condições / hipóteses a serem testadas)
				
%sigla(sigla,"Descrição da sigla").
sigla(fps, "First Person Shooter").
sigla(rts, "Real Time Strategy").
sigla(mmorpg, "Massive Multiplayer Online Role Playing Game").
				
%jogo("Nome do Jogo", sigla, estilo).				
jogo("Counter Strike", cs, fps).
jogo("Battlefield", bf, fps).
jogo("Age of Empires", aoe, rts).
jogo("World of Warcraft", wow, mmorpg).

censura(cs, 16).
censura(bf, 13).
censura(aoe, 10).
censura(wow, 12).

jogador("Alexandre", 45).
jogador("Dante", 4).
jogador("Thomas", 12).
jogador("Rafael", 25).

jogando(Jogador, Jogo) :- 
    jogo(Jogo, SiglaJogo, _),
	jogador(Jogador, IdadeJogador),
	censura(SiglaJogo, IdadeCensura),
	IdadeJogador >= IdadeCensura.

jogaOque(Jogador, Jogo, Sigla, DescricaoEstilo, Idade) :- 
	jogador(Jogador, Idade),
	jogo(Jogo, Sigla, E),
	sigla(E, DescricaoEstilo),
	jogando(Jogador, Jogo).





a_direita_de(maria,joao).
a_direita_de(jose,maria).
a_direita_de(julia,jose).
a_direita_de(jorge,julia).
a_direita_de(ana,jorge).
a_direita_de(iris,ana).		

a_esquerda_de(Pesq, Pdir) :- 
	a_direita_de(Pdir, Pesq).
	
noMeio(PessoaEsq, PessoaMeio, PessoaDir) :- 	
	a_esquerda_de(PessoaEsq, PessoaMeio),
	a_direita_de(PessoaDir, PessoaMeio).
	
%ta_na_ponta(Pessoa) :- 
%	a_direita_de(Pessoa,_),
%   not(noMeio(_,Pessoa,_)),
%	writeln(" ponta direita").

%ta_na_ponta(Pessoa) :- 
%	a_esquerda_de(Pessoa,_),
%   not(noMeio(_,Pessoa,_)),
%	writeln(" ponta esquerda").

ta_na_ponta(Pessoa) :- a_direita_de(Pessoa, _),
                       not(a_direita_de(_,Pessoa)). %ultima pessoa                       	
					   
ta_na_ponta(Pessoa) :- a_esquerda_de(Pessoa, _),
                       not(a_esquerda_de(_,Pessoa)).%primeira pessoa    





escreverDecrescente(Numero) :- Numero == -1, !.
escreverDecrescente(Numero) :- writeln(Numero), 
							   N is Numero - 1,
                               escreverDecrescente(N). %ponto de recursão

escreverCrescente(Numero) :- Numero == -1, !.
escreverCrescente(Numero) :- N is Numero - 1,
                             escreverCrescente(N), %ponto recursão
							 writeln(Numero).
							 
							  
fatorial(0,1). 
fatorial(Numero,Resposta) :-
   Numero > 0,
   N is Numero - 1,
   fatorial(N,R), %ponto da recursão
   Resposta is Numero * R.							  
							  

conecta(a,b,50).
conecta(a,f,25).
conecta(b,c,30).
conecta(c,d,40).
conecta(d,e,5).
conecta(f,d,115).
conecta(f,g,15).
conecta(g,h,30).
conecta(h,c,200).

caminho(O,D,CustoFinal) :- conecta(O,D,CustoFinal).
caminho(O,D,CustoFinal) :- conecta(O,I,CustoIntermediario),  
						   writeln(I),
						   caminho(I,D,CustoAcumulado),
                           CustoFinal is CustoIntermediario + CustoAcumulado.						   
					   


progenitor(homero, "homero filho").
progenitor("homero filho", bianca).
progenitor(bianca, breno).
progenitor(breno, alexandre).
caminho(O,D) :- progenitor(O,D).
caminho(O,D) :- progenitor(O, I),
                caminho(I,D).
