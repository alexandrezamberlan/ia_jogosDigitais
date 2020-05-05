%PROLOG
%	- linguagem lógica
%	- o programador informa o que quer
%	  e a linguagem dá o retorno
%	  
%	- linguagem baseada em lógica de
%	  predicados ou proposicional
%		- IA simbólica
%		
%	- fatos são predicados verdade
	pai(joao,zeno).
	pai(zeno,jurandir).
	pai(jurandir,alexandre).
	pai(jurandir,cristina).
	pai(jurandir,clarissa).
	pai(alexandre,dante).
	pai(clarissa,clara).
	
	avo(A,N) :- pai(A,P),
	            pai(P,N).
				
	antecessor(A,D) :- pai(A,D).
	antecessor(A,D) :- pai(A,I),
	                   antecessor(I,D).
	
	jogo(counterStrike,fps,pc).
	jogo(minecraft,aventura,pc).
	jogo(mario,plataforma,console).
	
	violento(counterStrike).
	
	kids(Jogo,Platforma) :- jogo(Jogo,_,Plataforma),
	                        not(violento(Jogo)).
	
	produto(violao).
	produto(guitarra).
	produto(tenis).
	produto(queijo).
	produto(vinho).
	produto(videogame).
	produto(pao).
	produto(cafe).
	produto(faca).
	
	barato(pao).
	barato(queijo).
	barato(cafe).
	barato(vinho).
	
	bom(guitarra).
	bom(violao).
	bom(videogame).
	bom(vinho).
	
	preciso(tenis).
	preciso(cafe).
	preciso(pao).
	preciso(queijo).
	preciso(videogame).
	
%	- regras são predicados que testam fatos
	bbb(P) :- produto(P),
	          barato(P),
			  bom(P).

	superfluo(P) :- produto(P),
	                not(preciso(P)),
					not(barato(P)).
	
	conecta(a,b).
	conecta(a,d).
	conecta(a,f).
	conecta(b,a).
	conecta(b,c).
	conecta(c,f).
	conecta(d,c).
	conecta(f,c).
	
	caminho(O,D) :- conecta(O,D).
	caminho(O,D) :- conecta(O,I),
	                caminho(I,D).
					
					
% fagner nasceu cruz alta
% bruno nasceu santo angelo
% rodrigo nasceu em paris
% pietro nasceu em santa maria
% matheus nasceu segredo
% luiz nasceu em itaqui
% ju nasceu em florianopolis

% cruz alta está no RS
% santo angelo esta RS
% paris esta em franca
% santa maria esta RS
% segredo esta em RS
% itaqui esta em RS
% florianopolis esta em SC

% Rs esta no Brasil
% SC esta no Brasil
% Brasil esta na america
% Franca esta na europa

nasceuEm(fagner,cruzAlta).
nasceuEm(bruno,santoAngelo).
nasceuEm(rodrigo,paris).
nasceuEm(pietro,santaMaria).
nasceuEm(matheus,segredo).
nasceuEm(luiz,itaqui).
nasceuEm(ju,florianopolis).
nasceuEm(Pessoa,Lugar) :- nasceuEm(Pessoa,I),
                          localizadoEm(I,Lugar).


localizadoEm(cruzAlta, rs).
localizadoEm(santoAngelo, rs).
localizadoEm(santaMaria, rs).
localizadoEm(segredo, rs).
localizadoEm(itaqui, rs).
localizadoEm(florianopolis, sc).
localizadoEm(rs, brasil).						
localizadoEm(sc, brasil).
localizadoEm(brasil, america).
localizadoEm(paris,franca).
localizadoEm(franca,europa).
localizadoEm(Lugar,OutroLugar) :- localizadoEm(Lugar,I),
                                  localizadoEm(I,OutroLugar).