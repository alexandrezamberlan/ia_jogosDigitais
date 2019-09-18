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
	
	