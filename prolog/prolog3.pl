%fatos que representam um banco de dados academico
aluno(100,eduardo).
aluno(101,flavio).
aluno(102,luther).
aluno(103,robson).

disciplina(1,"Inteligência Artificial").
disciplina(2,"Sistemas Distribuídos").
disciplina(3,"Projeto de Software").

professor(500,alexandre).
professor(600,fabricio).

turma(ia_2019_2,1,500).
turma(sd_2019_2,2,500).
turma(ps_2019_2,3,600).

matricula(100,ia_2019_2).
matricula(101,ia_2019_2).
matricula(102,ia_2019_2).
matricula(103,ia_2019_2).
matricula(100,sd_2019_2).
matricula(102,sd_2019_2).
matricula(101,ps_2019_2).
matricula(103,ps_2019_2).


consulta(CodA, NomeA, CodD, NomeD, CodP, NomeP) :- aluno(CodA,NomeA),
                                                   disciplina(CodD,NomeD),
                                                   professor(CodP,NomeP),
                                                   turma(CodT,CodD,CodP),
												   matricula(CodA,CodT).
												   
												   
fatorial(Numero,Resposta) :- Numero == 1, Resposta is 1,!.
fatorial(Numero,Resposta) :- N is Numero - 1,
                             fatorial(N,R),
							 Resposta is Numero * R.