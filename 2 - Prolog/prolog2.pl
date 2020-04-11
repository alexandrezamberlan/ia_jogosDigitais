pai("Zeno","Jurandir").
pai("Jurandir","Alexandre").
pai("Regina","Alexandre").
pai("Jurandir","Gustavo").
pai("Jurandir","Gustavo").

irmao(A,B) :- pai(Pai,A),
              pai(Pai,B),
			  A \= B.
			  
tio(T,S) :- pai(A,I),
            pai(A,T),
            pai(I,S),
            T \= I.			
			
avo(A,N) :- pai(A,P),
            pai(P,N).			