oldSchool(J) :- jogador(J,Idade),
                Idade > 40,
				status(J,Fase,_),
				Fase > 5.
				
destaque(Jogador,Fase,Pontuacao):-
	jogador(Jogador,_),
	status(Jogador,Fase,Pontuacao),
	Fase > 6.
	
destaque(Jogador,Fase,Pontuacao):-
	jogador(Jogador,_),
	status(Jogador,Fase,Pontuacao),
	Pontuacao > 1000.
	